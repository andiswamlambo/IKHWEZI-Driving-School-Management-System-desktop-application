using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Driving_School_System_Forms;

namespace Driving_school_login_form
{
    public partial class AvailableSessions : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private readonly int[] SessionHours = { 8, 9, 10, 11, 12, 13, 14, 15, 16 };

        public AvailableSessions()
        {
            InitializeComponent();
            SetupGrid();
            mcInstructorCalendar.MinDate = DateTime.Today;
            mcInstructorCalendar.DateSelected += mcInstructorCalendar_DateSelected;
            PopulateSlots(DateTime.Today);
            HighlightBusyDates();
        }

        // ──────────────────────────────────────────────
        //  Setup DataGridView
        // ──────────────────────────────────────────────
        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TimeSlot",
                HeaderText = "Time",
                Name = "TimeSlot",
                Width = 75,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InstructorName",
                HeaderText = "Instructor",
                Name = "InstructorName",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Padding = new Padding(5, 0, 0, 0) }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LicenceType",
                HeaderText = "Licence",
                Name = "LicenceType",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Specialization",
                HeaderText = "Specialization",
                Name = "Specialization",
                Width = 130
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Availability",
                HeaderText = "Status",
                Name = "Availability",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            dataGridView1.GridColor = Color.FromArgb(189, 195, 199);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowTemplate.Height = 26;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cell = row.Cells["Availability"];
                if (cell?.Value == null) continue;

                if (cell.Value.ToString() == "Available")
                {
                    cell.Style.BackColor = Color.FromArgb(46, 204, 113);
                    cell.Style.ForeColor = Color.White;
                    cell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else
                {
                    cell.Style.BackColor = Color.FromArgb(231, 76, 60);
                    cell.Style.ForeColor = Color.White;
                    cell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        // ──────────────────────────────────────────────
        //  Calendar
        // ──────────────────────────────────────────────
        private void mcInstructorCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start.Date < DateTime.Today) return;
            PopulateSlots(e.Start.Date);
        }

        private void HighlightBusyDates()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "SELECT DISTINCT CAST(LessonDateTime AS DATE) AS LessonDate " +
                        "FROM Lesson " +
                        "WHERE LessonDateTime >= @StartDate " +
                        "AND Status IN ('Pending', 'Confirmed', 'Rescheduled')";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", DateTime.Today);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            var boldDates = new List<DateTime>();
                            while (reader.Read())
                            {
                                boldDates.Add(Convert.ToDateTime(reader["LessonDate"]));
                            }
                            if (boldDates.Count > 0)
                            {
                                mcInstructorCalendar.BoldedDates = boldDates.ToArray();
                            }
                        }
                    }
                }
            }
            catch { /* Non-critical */ }
        }

        // ──────────────────────────────────────────────
        //  Populate slots
        // ──────────────────────────────────────────────
        private void PopulateSlots(DateTime date)
        {
            lblScheduleHeader.Text = "Sessions for " + date.ToString("ddd, dd MMM yyyy");

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    var bookedSlots = new HashSet<string>();
                    string bookedQuery =
                        "SELECT DATEPART(HOUR, l.LessonDateTime) AS HourSlot, " +
                        "l.InstruEmailAddress " +
                        "FROM Lesson l " +
                        "WHERE CAST(l.LessonDateTime AS DATE) = @SelectedDate " +
                        "AND l.Status IN ('Pending', 'Confirmed', 'Rescheduled')";

                    using (SqlCommand cmd = new SqlCommand(bookedQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", date.Date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int hour = Convert.ToInt32(reader["HourSlot"]);
                                string email = reader["InstruEmailAddress"].ToString();
                                bookedSlots.Add(hour + "|" + email);
                            }
                        }
                    }

                    var instructors = new List<InstructorInfo>();
                    string instructorQuery =
                        "SELECT InstruEmailAddress, Name, Surname, LicenceType, Specialization " +
                        "FROM Instructor";

                    using (SqlCommand cmd = new SqlCommand(instructorQuery, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                instructors.Add(new InstructorInfo
                                {
                                    Email = reader["InstruEmailAddress"].ToString(),
                                    FullName = reader["Name"].ToString() + " " + reader["Surname"].ToString(),
                                    LicenceType = reader["LicenceType"].ToString(),
                                    Specialization = reader["Specialization"]?.ToString() ?? ""
                                });
                            }
                        }
                    }

                    DataTable dt = new DataTable();
                    dt.Columns.Add("TimeSlot", typeof(string));
                    dt.Columns.Add("InstructorName", typeof(string));
                    dt.Columns.Add("LicenceType", typeof(string));
                    dt.Columns.Add("Specialization", typeof(string));
                    dt.Columns.Add("Availability", typeof(string));

                    int availableCount = 0;
                    int bookedCount = 0;

                    foreach (int hour in SessionHours)
                    {
                        string timeLabel = FormatHour(hour);

                        foreach (var instr in instructors)
                        {
                            string key = hour + "|" + instr.Email;
                            bool isBooked = bookedSlots.Contains(key);

                            dt.Rows.Add(
                                timeLabel,
                                instr.FullName,
                                instr.LicenceType,
                                instr.Specialization,
                                isBooked ? "Booked" : "Available"
                            );

                            if (isBooked) bookedCount++; else availableCount++;
                        }
                    }

                    dataGridView1.DataSource = dt;

                    lblAvailableCount.Text = availableCount.ToString();
                    lblBookedCount.Text = bookedCount.ToString();
                    lblTotalCount.Text = (availableCount + bookedCount).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatHour(int hour)
        {
            if (hour == 0) return "12:00 AM";
            if (hour < 12) return hour.ToString("00") + ":00 AM";
            if (hour == 12) return "12:00 PM";
            return (hour - 12).ToString("00") + ":00 PM";
        }

        // ──────────────────────────────────────────────
        //  Buttons
        // ──────────────────────────────────────────────
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form targetForm;

            switch (CurrentUser.Role)
            {
                case "Instructor":
                    targetForm = new InstructorForm();
                    break;
                case "Receptionist":
                    targetForm = new ReceptionistForm();
                    break;
                case "Manager":
                    targetForm = new ManagerForm();
                    break;
                default:
                    targetForm = new FormLogin();
                    break;
            }
            targetForm.Show();
            this.Hide();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PopulateSlots(mcInstructorCalendar.SelectionStart);
            HighlightBusyDates();
        }

        private void AvailableSessions_Load(object sender, EventArgs e) { }

        // ──────────────────────────────────────────────
        //  Designer-wired empty handler
        // ──────────────────────────────────────────────
        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {
            // Empty — just satisfies the Designer's wired event handler
        }
    }

    public class InstructorInfo
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string LicenceType { get; set; }
        public string Specialization { get; set; }
    }
}