using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Driving_school_login_form;

namespace Driving_School_System_Forms
{
    public partial class InstructorForm : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public InstructorForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            pnlDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAssignedSessions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadAssignedSessionsGrid();

            if (!string.IsNullOrEmpty(CurrentUser.FullName))
            {
                lblWelcome.Text = "Welcome, " + CurrentUser.FullName;
            }
        }

        // ============================================================
        // CARD COUNTS — Booking + Students
        // ============================================================
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string instructorEmail = CurrentUser.Email;

                    // Card 1: unique students assigned to this instructor
                    string studentQuery =
                        "SELECT COUNT(DISTINCT StudEmailAddress) FROM Booking WHERE StafEmailAddress = @InstructorEmail";
                    using (SqlCommand cmd = new SqlCommand(studentQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@InstructorEmail", instructorEmail);
                        object result = cmd.ExecuteScalar();
                        lblCard1Value.Text = result != null ? result.ToString() : "0";
                    }

                    // Card 2: bookings scheduled for today
                    string lessonQuery =
                        "SELECT COUNT(*) FROM Booking " +
                        "WHERE CAST(ScheduledDateTime AS DATE) = CAST(GETDATE() AS DATE) " +
                        "AND StafEmailAddress = @InstructorEmail";
                    using (SqlCommand cmd = new SqlCommand(lessonQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@InstructorEmail", instructorEmail);
                        object result = cmd.ExecuteScalar();
                        lblCard2Value.Text = result != null ? result.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // ASSIGNED SESSIONS GRID — Booking → Students → Packages
        // ============================================================
        private void LoadAssignedSessionsGrid()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT 
                            b.ScheduledDateTime AS 'Lesson Date & Time',
                            s.Name              AS 'Student Name',
                            s.Surname           AS 'Student Surname',
                            p.PackageName       AS 'Package',
                            b.BookingStatus     AS 'Status'
                        FROM Booking b
                        INNER JOIN Students s ON b.StudEmailAddress = s.StudEmailAddress
                        LEFT  JOIN Packages p ON b.PackageID       = p.PackageID
                        WHERE b.StafEmailAddress = @InstructorEmail
                        ORDER BY b.ScheduledDateTime DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@InstructorEmail", CurrentUser.Email);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvAssignedSessions.AutoGenerateColumns = true;
                        dgvAssignedSessions.DataSource = dt;
                        dgvAssignedSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // CARD 1 — Assigned Students
        // ============================================================
        private void pnlCard1_Click(object sender, EventArgs e)
        {
            ReceptionistSessions receptionistSessions = new ReceptionistSessions();
            receptionistSessions.Show();
            this.Hide();
        }
        private void lblCard1Title_Click(object sender, EventArgs e)
        {
            AssigndSession assigndSession = new AssigndSession();
            assigndSession.Show();
            this.Hide();
        }
        private void lblCard1Value_Click(object sender, EventArgs e)
        {
            ReceptionistSessions receptionistSessions = new ReceptionistSessions();
            receptionistSessions.Show();
            this.Hide();
        }

        // ============================================================
        // CARD 2 — Today's Sessions
        // ============================================================
        private void pnlCard2_Click(object sender, EventArgs e)
        {
            btnUpdateStatus_Click_1(sender, e);
        }
        private void lblCard2Title_Click(object sender, EventArgs e)
        {
            pnlCard2_Click(sender, e);
        }
        private void lblCard2Value_Click(object sender, EventArgs e)
        {
            pnlCard2_Click(sender, e);
        }

        // ============================================================
        // STANDARD FORM METHODS
        // ============================================================
        private void label7_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void pnlCard1_Paint(object sender, PaintEventArgs e) { }
        private void pnlCard2_Paint(object sender, PaintEventArgs e) { }
        private void dgvAssignedSessions_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnUpdateStatus_Click_1(object sender, EventArgs e)
        {
            LessonStatusForm lessonStatus = new LessonStatusForm();
            lessonStatus.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnViewAssigned_Click(object sender, EventArgs e)
        {
            AssigndSession assigndSession = new AssigndSession();
            assigndSession.Show();
            this.Hide();
        }

        private void lblWelcome_Click(object sender, EventArgs e) { }

        private void btnLessonHistory_Click(object sender, EventArgs e) { }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
            this.Hide();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e) { }
    }
}