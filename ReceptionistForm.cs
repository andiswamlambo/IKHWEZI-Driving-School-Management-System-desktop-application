
using Driving_school_login_form;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_School_System_Forms
{
    public partial class ReceptionistForm : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public ReceptionistForm()
        {
            InitializeComponent();

            this.Load += ReceptionistForm_Load;
            this.Resize += ReceptionistForm_Resize;

            this.WindowState = FormWindowState.Maximized;

            pnlDataGrid.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvUpcomingSessions.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            lblWelcome.Text = "Welcome, " + CurrentUser.FullName;
            this.Text = "Receptionist Dashboard - " + CurrentUser.FullName;

            LoadDashboardData();
            LoadUpcomingSessionsGrid();
        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            // Dashboard card titles
            lblCard1Title.Text = "Total Students";
            lblCard2Title.Text = "Active Lessons";
            lblCard3Title.Text = "Bookings Today";
            lblCard4Title.Text = "Total Vehicles";

            LoadDashboardData();
            LoadUpcomingSessionsGrid();

            lblWelcome.Text = "Welcome, " + CurrentUser.FullName;
            this.Text = "Receptionist Dashboard - " + CurrentUser.FullName;

            ResizeDashboardCards();

            linkLabel1.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;

            pnlDataGrid.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvUpcomingSessions.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
        }

        private void ReceptionistForm_Resize(object sender, EventArgs e)
        {
            ResizeDashboardCards();
        }

        // ==========================================
        // DASHBOARD CARD LAYOUT
        // ==========================================
        private void ResizeDashboardCards()
        {
            int totalCards = 4;
            int spacing = 20;
            int totalSpacing = spacing * (totalCards + 1);

            int availableWidth =
                this.ClientSize.Width - totalSpacing;

            int cardWidth = availableWidth / totalCards;

            pnlCard1.Width = cardWidth;
            pnlCard1.Left = spacing;

            pnlCard2.Width = cardWidth;
            pnlCard2.Left = pnlCard1.Right + spacing;

            pnlCard3.Width = cardWidth;
            pnlCard3.Left = pnlCard2.Right + spacing;

            pnlCard4.Width = cardWidth;
            pnlCard4.Left = pnlCard3.Right + spacing;
        }

        // ==========================================
        // DASHBOARD DATA
        // ==========================================
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(ConnectionString))
                {
                    con.Open();

                    // Total Students
                    using (SqlCommand cmdStudents =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Students", con))
                    {
                        lblCard1Value.Text =
                            cmdStudents.ExecuteScalar().ToString();
                    }

                    // Active Lessons
                    // Counts records currently stored in Lesson
                    using (SqlCommand cmdLessons =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Lesson", con))
                    {
                        lblCard2Value.Text =
                            cmdLessons.ExecuteScalar().ToString();
                    }

                    // Bookings Today
                    using (SqlCommand cmdToday =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Booking " +
                            "WHERE CAST(ScheduledDateTime AS DATE) = " +
                            "CAST(GETDATE() AS DATE)", con))
                    {
                        lblCard3Value.Text =
                            cmdToday.ExecuteScalar().ToString();
                    }

                    // Total Vehicles
                    using (SqlCommand cmdVehicles =
                        new SqlCommand(
                            "SELECT COUNT(*) FROM Vehicles", con))
                    {
                        lblCard4Value.Text =
                            cmdVehicles.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading dashboard data: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // UPCOMING SESSIONS GRID
        // ==========================================
        private void LoadUpcomingSessionsGrid()
        {
            try
            {
                using (SqlConnection con =
                    new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string query = @"
                        SELECT
                            b.ScheduledDateTime AS 'Date & Time',
                            s.Name + ' ' + s.Surname AS 'Student Name',
                            ISNULL(
                                i.Name + ' ' + i.Surname,
                                b.StafEmailAddress
                            ) AS 'Instructor Name',
                            ISNULL(p.PackageName, '') AS 'Package',
                            b.BookingStatus AS 'Status'
                        FROM Booking b
                        INNER JOIN Students s
                            ON b.StudEmailAddress = s.StudEmailAddress
                        LEFT JOIN Instructor i
                            ON b.StafEmailAddress = i.InstruEmailAddress
                        LEFT JOIN Packages p
                            ON b.PackageID = p.PackageID
                        ORDER BY b.ScheduledDateTime ASC";

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvUpcomingSessions.AutoGenerateColumns = true;
                        dgvUpcomingSessions.DataSource = dt;

                        dgvUpcomingSessions.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading sessions: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CARD CLICK HANDLERS
        // ==========================================

        // Card 1 - Total Students
        private void pnlCard1_Click(object sender, EventArgs e)
        {
            btnLessonHistory_Click_1(sender, e);
        }

        private void lblCard1Title_Click(object sender, EventArgs e)
        {
            btnLessonHistory_Click_1(sender, e);
        }

        private void lblCard1Value_Click(object sender, EventArgs e)
        {
            btnLessonHistory_Click_1(sender, e);
        }

        // Card 2 - Active Lessons
        private void pnlCard2_Click(object sender, EventArgs e)
        {
            btnViewTransactions_Click_1(sender, e);
        }

        private void lblCard2Title_Click(object sender, EventArgs e)
        {
            btnViewTransactions_Click_1(sender, e);
        }

        private void lblCard2Value_Click(object sender, EventArgs e)
        {
            btnViewTransactions_Click_1(sender, e);
        }

        // Card 3 - Bookings Today
        private void pnlCard3_Click(object sender, EventArgs e)
        {
            btnViewAssigned_Click(sender, e);
        }

        private void lblCard3Title_Click(object sender, EventArgs e)
        {
            btnViewAssigned_Click(sender, e);
        }

        private void lblCard3Value_Click(object sender, EventArgs e)
        {
            btnViewAssigned_Click(sender, e);
        }

        // Card 4 - Vehicles
        private void pnlCard4_Click(object sender, EventArgs e)
        {
            ManageVehicle mv = new ManageVehicle();
            mv.Show();
            this.Hide();
        }

        private void lblCard4Title_Click(object sender, EventArgs e)
        {
            ManageVehicle mv = new ManageVehicle();
            mv.Show();
            this.Hide();
        }

        private void lblCard4Value_Click(object sender, EventArgs e)
        {
            ManageVehicle mv = new ManageVehicle();
            mv.Show();
            this.Hide();
        }

        // ==========================================
        // STANDARD FORM METHODS
        // ==========================================
        private void label7_Click(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void pnlCard1_Paint(object sender, PaintEventArgs e) { }

        private void pnlCard2_Paint(object sender, PaintEventArgs e) { }

        private void pnlCard3_Paint(object sender, PaintEventArgs e) { }

        private void pnlCard4_Paint(object sender, PaintEventArgs e) { }

        private void dgvUpcomingSessions_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        { }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e) { }

        private void lblWelcome_Click(object sender, EventArgs e) { }

        // ==========================================
        // NAVIGATION
        // ==========================================
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegisterStudentsForm stud = new RegisterStudentsForm();
            stud.Show();
            this.Hide();
        }

        private void btnLessonHistory_Click_1(object sender, EventArgs e)
        {
            History lessons = new History();
            lessons.Show();
            this.Hide();
        }

        private void btnViewTransactions_Click_1(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btnViewAvailable_Click(object sender, EventArgs e)
        {
            AvailableSessions sessions = new AvailableSessions();
            sessions.Show();
            this.Hide();
        }

        private void btnBookSession_Click(object sender, EventArgs e)
        {
            MakeBooking book = new MakeBooking();
            book.Show();
            this.Hide();
        }

        private void btnViewAssigned_Click(object sender, EventArgs e)
        {
            ReceptionistSessions assigned =
                new ReceptionistSessions();

            assigned.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifyPayments verifyPayments =
                new VerifyPayments();

            verifyPayments.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
            this.Hide();
        }
    }
}
