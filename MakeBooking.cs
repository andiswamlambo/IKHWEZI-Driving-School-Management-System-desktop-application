using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class MakeBooking : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public MakeBooking()
        {
            InitializeComponent();
            SetupGrid();
            WirePanelClicks();
        }

        // ──────────────────────────────────────────────
        //  Setup DataGridView Columns & Style
        // ──────────────────────────────────────────────
        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StudentName",
                HeaderText = "Student",
                Name = "StudentName",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle { Padding = new Padding(5, 0, 0, 0) }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PackageName",
                HeaderText = "Package",
                Name = "PackageName",
                Width = 150
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LessonType",
                HeaderText = "Lesson Type",
                Name = "LessonType",
                Width = 130
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Duration",
                HeaderText = "Duration",
                Name = "Duration",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LessonDateTime",
                HeaderText = "Date & Time",
                Name = "LessonDateTime",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InstructorEmail",
                HeaderText = "Instructor",
                Name = "InstructorEmail",
                Width = 160
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BookingStatus",
                HeaderText = "Status",
                Name = "BookingStatus",
                Width = 85,
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
            dataGridView1.RowTemplate.Height = 28;
        }

        // ──────────────────────────────────────────────
        //  Make Panels Clickable
        // ──────────────────────────────────────────────
        private void WirePanelClicks()
        {
            pnlCard1.Click += pnlCard1_Click;
            panel2.Click += panel2_Click;
            panel3.Click += panel3_Click;
            panel4.Click += panel4_Click;

            foreach (Control c in pnlCard1.Controls) c.Click += pnlCard1_Click;
            foreach (Control c in panel2.Controls) c.Click += panel2_Click;
            foreach (Control c in panel3.Controls) c.Click += panel3_Click;
            foreach (Control c in panel4.Controls) c.Click += panel4_Click;
        }

        private void pnlCard1_Click(object sender, EventArgs e)
        {
            LoadBookings();
            HighlightPanel(pnlCard1);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            LoadBookingsByStatus("Confirmed");
            HighlightPanel(panel2);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            LoadBookingsByStatus("Pending");
            HighlightPanel(panel3);
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            LoadBookingsByStatus("Cancelled");
            HighlightPanel(panel4);
        }

        private void HighlightPanel(Panel active)
        {
            pnlCard1.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
            panel4.BorderStyle = BorderStyle.None;
            active.BorderStyle = BorderStyle.FixedSingle;
        }

        // ──────────────────────────────────────────────
        //  Form Load
        // ──────────────────────────────────────────────
        private void MakeBooking_Load(object sender, EventArgs e)
        {
            LoadCounts();
            LoadBookings();
            HighlightPanel(pnlCard1);
        }

        // ──────────────────────────────────────────────
        //  Base Query — Students + Packages
        // ──────────────────────────────────────────────
        private string GetBaseQuery()
        {
            return
                "SELECT " +
                "  ISNULL(b.BookingID, 0) AS BookingID, " +
                "  ISNULL(s.Name, '') + ' ' + ISNULL(s.Surname, '') AS StudentName, " +
                "  ISNULL(b.StudEmailAddress, '') AS StudEmailAddress, " +
                "  ISNULL(b.StafEmailAddress, '') AS InstructorEmail, " +
                "  ISNULL(b.PackageID, 0) AS PackageID, " +
                "  ISNULL(p.PackageName, '') AS PackageName, " +
                "  ISNULL(l.LessonType, '') AS LessonType, " +
                "  ISNULL(l.Duration, 0) AS Duration, " +
                "  ISNULL(l.LessonDateTime, b.ScheduledDateTime) AS LessonDateTime, " +
                "  ISNULL(l.Status, '') AS LessonStatus, " +
                "  ISNULL(b.BookingStatus, '') AS BookingStatus " +
                "FROM Booking b " +
                "LEFT JOIN Students s ON b.StudEmailAddress = s.StudEmailAddress " +
                "JOIN Packages p ON b.PackageID = p.PackageID " +
                "LEFT JOIN Lesson l ON b.BookingID = l.BookingID";
        }

        // ──────────────────────────────────────────────
        //  Load Bookings
        // ──────────────────────────────────────────────
        private void LoadBookings()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = GetBaseQuery() + " ORDER BY ISNULL(l.LessonDateTime, b.ScheduledDateTime) DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookingsByStatus(string status)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = GetBaseQuery() +
                        " WHERE b.BookingStatus = @Status" +
                        " ORDER BY ISNULL(l.LessonDateTime, b.ScheduledDateTime) DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Status", status);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Load Counts
        // ──────────────────────────────────────────────
        private void LoadCounts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM Booking", con);
                    lblTotal.Text = cmdTotal.ExecuteScalar().ToString();

                    SqlCommand cmdPending = new SqlCommand("SELECT COUNT(*) FROM Booking WHERE BookingStatus = 'Pending'", con);
                    lblPending.Text = cmdPending.ExecuteScalar().ToString();

                    SqlCommand cmdCancelled = new SqlCommand("SELECT COUNT(*) FROM Booking WHERE BookingStatus = 'Cancelled'", con);
                    lblCancelled.Text = cmdCancelled.ExecuteScalar().ToString();

                    SqlCommand cmdConfirmed = new SqlCommand("SELECT COUNT(*) FROM Booking WHERE BookingStatus = 'Confirmed'", con);
                    lblConfirmed.Text = cmdConfirmed.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading counts: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Search — Reacts to Every Keystroke
        // ──────────────────────────────────────────────
        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = roundedTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadBookings();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = GetBaseQuery() +
                        " WHERE " +
                        "  ISNULL(s.Name, '') + ' ' + ISNULL(s.Surname, '') LIKE @Search " +
                        "  OR ISNULL(b.StudEmailAddress, '') LIKE @Search " +
                        "  OR ISNULL(b.StafEmailAddress, '') LIKE @Search " +
                        "  OR ISNULL(b.BookingStatus, '') LIKE @Search " +
                        "  OR ISNULL(p.PackageName, '') LIKE @Search " +
                        "  OR ISNULL(l.LessonType, '') LIKE @Search " +
                        " ORDER BY ISNULL(l.LessonDateTime, b.ScheduledDateTime) DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message,
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Buttons
        // ──────────────────────────────────────────────
        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistForm frm = new ReceptionistForm();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roundedTextBox1.Text = "";
            LoadBookings();
            LoadCounts();
            HighlightPanel(pnlCard1);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            NewBooking newBook = new NewBooking();
            newBook.Show();
            this.Hide();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = GetBaseQuery() +
                        " WHERE CAST(ISNULL(l.LessonDateTime, b.ScheduledDateTime) AS DATE) = CAST(GETDATE() AS DATE)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No lessons scheduled for today.", "Today's Lessons",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(dt.Rows.Count + " lesson(s) scheduled for today.", "Today's Lessons",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = GetBaseQuery() +
                        " WHERE CAST(ISNULL(l.LessonDateTime, b.ScheduledDateTime) AS DATE) >= CAST(GETDATE() AS DATE) " +
                        " AND CAST(ISNULL(l.LessonDateTime, b.ScheduledDateTime) AS DATE) <= DATEADD(DAY, 7, CAST(GETDATE() AS DATE))";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                        MessageBox.Show("No lessons scheduled for this week.", "Weekly Bookings",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(dt.Rows.Count + " lesson(s) scheduled for this week.", "Weekly Bookings",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblCard1Value_Click(object sender, EventArgs e) { }

        private void pnlCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}