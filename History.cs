using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class History : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private string _currentFilter = "All";

        public History()
        {
            InitializeComponent();
            SetupGrid();
            WireCardClicks();
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
                DataPropertyName = "BookingID",
                HeaderText = "#",
                Name = "BookingID",
                Width = 40,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
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
                DataPropertyName = "StudEmailAddress",
                HeaderText = "Email",
                Name = "StudEmailAddress",
                Width = 160
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
                HeaderText = "Lesson",
                Name = "LessonType",
                Width = 120
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ScheduledDateTime",
                HeaderText = "Date & Time",
                Name = "ScheduledDateTime",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm", Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InstructorName",
                HeaderText = "Instructor",
                Name = "InstructorName",
                Width = 120
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod",
                HeaderText = "Payment",
                Name = "PaymentMethod",
                Width = 75,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AmountPaid",
                HeaderText = "Amount",
                Name = "AmountPaid",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "R #,##0.00", Alignment = DataGridViewContentAlignment.MiddleRight }
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

            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var cell = row.Cells["BookingStatus"];
                if (cell?.Value == null) continue;

                switch (cell.Value.ToString())
                {
                    case "Confirmed":
                        cell.Style.BackColor = Color.FromArgb(46, 204, 113);
                        cell.Style.ForeColor = Color.White;
                        break;
                    case "Pending":
                        cell.Style.BackColor = Color.FromArgb(241, 196, 15);
                        cell.Style.ForeColor = Color.Black;
                        break;
                    case "Cancelled":
                        cell.Style.BackColor = Color.FromArgb(231, 76, 60);
                        cell.Style.ForeColor = Color.White;
                        break;
                    case "Completed":
                        cell.Style.BackColor = Color.FromArgb(52, 152, 219);
                        cell.Style.ForeColor = Color.White;
                        break;
                }

                var amountCell = row.Cells["AmountPaid"];
                if (amountCell?.Value != null && amountCell.Value != DBNull.Value)
                {
                    amountCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        // ──────────────────────────────────────────────
        //  Card clicks
        // ──────────────────────────────────────────────
        private void WireCardClicks()
        {
            pnlCardAll.Click += pnlCardAll_Click;
            pnlCardConfirmed.Click += pnlCardConfirmed_Click;
            pnlCardPending.Click += pnlCardPending_Click;
            pnlCardCancelled.Click += pnlCardCancelled_Click;

            foreach (Control c in pnlCardAll.Controls) c.Click += pnlCardAll_Click;
            foreach (Control c in pnlCardConfirmed.Controls) c.Click += pnlCardConfirmed_Click;
            foreach (Control c in pnlCardPending.Controls) c.Click += pnlCardPending_Click;
            foreach (Control c in pnlCardCancelled.Controls) c.Click += pnlCardCancelled_Click;
        }

        private void pnlCardAll_Click(object sender, EventArgs e)
        {
            _currentFilter = "All";
            LoadHistory(textBox1.Text);
            HighlightCard(pnlCardAll);
        }

        private void pnlCardConfirmed_Click(object sender, EventArgs e)
        {
            _currentFilter = "Confirmed";
            LoadHistory(textBox1.Text);
            HighlightCard(pnlCardConfirmed);
        }

        private void pnlCardPending_Click(object sender, EventArgs e)
        {
            _currentFilter = "Pending";
            LoadHistory(textBox1.Text);
            HighlightCard(pnlCardPending);
        }

        private void pnlCardCancelled_Click(object sender, EventArgs e)
        {
            _currentFilter = "Cancelled";
            LoadHistory(textBox1.Text);
            HighlightCard(pnlCardCancelled);
        }

        private void HighlightCard(Panel active)
        {
            pnlCardAll.BorderStyle = BorderStyle.None;
            pnlCardConfirmed.BorderStyle = BorderStyle.None;
            pnlCardPending.BorderStyle = BorderStyle.None;
            pnlCardCancelled.BorderStyle = BorderStyle.None;
            active.BorderStyle = BorderStyle.FixedSingle;
        }

        // ──────────────────────────────────────────────
        //  Form Load
        // ──────────────────────────────────────────────
        private void History_Load(object sender, EventArgs e)
        {
            LoadHistory("");
            LoadCounts();
            HighlightCard(pnlCardAll);
        }

        // ──────────────────────────────────────────────
        //  Load History
        // ──────────────────────────────────────────────
        private void LoadHistory(string searchTerm)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    // Students + Packages (plural). LEFT JOIN Instructor because
                    // StafEmailAddress may be a receptionist. LEFT JOIN Payment
                    // because a booking may not yet have a payment record.
                    string query =
                        "SELECT " +
                        "  ISNULL(b.BookingID, 0) AS BookingID, " +
                        "  ISNULL(s.Name, '') + ' ' + ISNULL(s.Surname, '') AS StudentName, " +
                        "  ISNULL(b.StudEmailAddress, '') AS StudEmailAddress, " +
                        "  ISNULL(p.PackageName, '') AS PackageName, " +
                        "  ISNULL(l.LessonType, '') AS LessonType, " +
                        "  ISNULL(b.ScheduledDateTime, GETDATE()) AS ScheduledDateTime, " +
                        "  ISNULL(i.Name, '') + ' ' + ISNULL(i.Surname, '') AS InstructorName, " +
                        "  ISNULL(pay.PaymentMethod, '') AS PaymentMethod, " +
                        "  ISNULL(pay.AmountPaid, 0) AS AmountPaid, " +
                        "  ISNULL(b.BookingStatus, '') AS BookingStatus " +
                        "FROM Booking b " +
                        "INNER JOIN Students s ON b.StudEmailAddress = s.StudEmailAddress " +
                        "LEFT  JOIN Packages  p ON b.PackageID = p.PackageID " +
                        "LEFT  JOIN Lesson    l ON b.BookingID = l.BookingID " +
                        "LEFT  JOIN Instructor i ON b.StafEmailAddress = i.InstruEmailAddress " +
                        "LEFT  JOIN Payment   pay ON b.BookingID = pay.BookingID " +
                        "WHERE (@SearchTerm = '' " +
                        "  OR ISNULL(s.Name, '') + ' ' + ISNULL(s.Surname, '') LIKE '%' + @SearchTerm + '%' " +
                        "  OR ISNULL(b.StudEmailAddress, '') LIKE '%' + @SearchTerm + '%' " +
                        "  OR ISNULL(p.PackageName, '') LIKE '%' + @SearchTerm + '%' " +
                        "  OR ISNULL(l.LessonType, '') LIKE '%' + @SearchTerm + '%' " +
                        "  OR ISNULL(i.Name, '') LIKE '%' + @SearchTerm + '%') " +
                        "AND (@Filter = 'All' OR ISNULL(b.BookingStatus, '') = @Filter) " +
                        "ORDER BY b.ScheduledDateTime DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SearchTerm",
                            string.IsNullOrWhiteSpace(searchTerm) ? "" : searchTerm.Trim());
                        cmd.Parameters.AddWithValue("@Filter", _currentFilter);

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

                UpdateResultCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Load counts
        // ──────────────────────────────────────────────
        private void LoadCounts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM Booking", con);
                    lblCountAll.Text = cmdTotal.ExecuteScalar().ToString();

                    SqlCommand cmdConfirmed = new SqlCommand(
                        "SELECT COUNT(*) FROM Booking WHERE BookingStatus = 'Confirmed'", con);
                    lblCountConfirmed.Text = cmdConfirmed.ExecuteScalar().ToString();

                    SqlCommand cmdPending = new SqlCommand(
                        "SELECT COUNT(*) FROM Booking WHERE BookingStatus = 'Pending'", con);
                    lblCountPending.Text = cmdPending.ExecuteScalar().ToString();

                    SqlCommand cmdCancelled = new SqlCommand(
                        "SELECT COUNT(*) FROM Booking WHERE BookingStatus = 'Cancelled'", con);
                    lblCountCancelled.Text = cmdCancelled.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading counts: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateResultCount()
        {
            int count = dataGridView1.Rows.Count;
            string filterText = _currentFilter == "All" ? "" : $" ({_currentFilter})";
            lblResults.Text = count + " booking" + (count == 1 ? "" : "s") + " found" + filterText;
        }

        // ──────────────────────────────────────────────
        //  Search
        // ──────────────────────────────────────────────
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadHistory(textBox1.Text);
        }

        // ──────────────────────────────────────────────
        //  Buttons
        // ──────────────────────────────────────────────
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            _currentFilter = "All";
            LoadHistory("");
            LoadCounts();
            HighlightCard(pnlCardAll);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
           ReceptionistForm recap = new ReceptionistForm();
            recap.Show();
            this.Hide();
        }
    }
}