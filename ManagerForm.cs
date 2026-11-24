
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Driving_school_login_form;

namespace Driving_School_System_Forms
{
    public partial class ManagerForm : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public ManagerForm()
        {
            InitializeComponent();

            this.pnlMainContent.Resize += pnlMainContent_Resize;
            pnlMainContent.Anchor = AnchorStyles.Top |
                                   AnchorStyles.Bottom |
                                   AnchorStyles.Left |
                                   AnchorStyles.Right;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + CurrentUser.FullName;
            this.Text = "Manager Dashboard - " + CurrentUser.FullName;

            // Dashboard card titles
            lblCard1Title.Text = "Students";
            lblCard2Title.Text = "Instructors";
            lblCard3Title.Text = "Total Revenue";
            lblCard4Title.Text = "Vehicles";

            LoadDashboardData();
            LayoutDashboard();
        }

        // ==========================================
        // DASHBOARD DATA
        // ==========================================
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    // Total Students
                    using (SqlCommand cmdStudents =
                        new SqlCommand("SELECT COUNT(*) FROM Students", con))
                    {
                        lblCard1Value.Text =
                            cmdStudents.ExecuteScalar().ToString();
                    }

                    // Total Instructors
                    using (SqlCommand cmdInstructors =
                        new SqlCommand("SELECT COUNT(*) FROM Instructor", con))
                    {
                        lblCard2Value.Text =
                            cmdInstructors.ExecuteScalar().ToString();
                    }

                    // Total Paid Revenue
                    using (SqlCommand cmdRevenue =
                        new SqlCommand(
                            "SELECT ISNULL(SUM(AmountPaid), 0) " +
                            "FROM Payment WHERE PaymentStatus = 'Paid'", con))
                    {
                        decimal totalRevenue =
                            Convert.ToDecimal(cmdRevenue.ExecuteScalar());

                        lblCard3Value.Text =
                            "R " + totalRevenue.ToString("N2");
                    }

                    // Total Vehicles
                    using (SqlCommand cmdVehicles =
                        new SqlCommand("SELECT COUNT(*) FROM Vehicles", con))
                    {
                        lblCard4Value.Text =
                            cmdVehicles.ExecuteScalar().ToString();
                    }

                    // Recent Bookings - Top 10
                    string bookingQuery = @"
                        SELECT TOP 10
                            b.BookingID,
                            s.Name + ' ' + s.Surname AS Student,
                            p.PackageName,
                            b.ScheduledDateTime,
                            b.BookingStatus
                        FROM Booking b
                        INNER JOIN Students s
                            ON b.StudEmailAddress = s.StudEmailAddress
                        INNER JOIN Packages p
                            ON b.PackageID = p.PackageID
                        ORDER BY b.ScheduledDateTime DESC";

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(bookingQuery, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvDashboard.AutoGenerateColumns = true;
                        dgvDashboard.DataSource = dt;

                        if (dgvDashboard.Columns.Count > 0)
                        {
                            if (dgvDashboard.Columns["BookingID"] != null)
                            {
                                dgvDashboard.Columns["BookingID"].HeaderText = "#";
                            }

                            if (dgvDashboard.Columns["ScheduledDateTime"] != null)
                            {
                                dgvDashboard.Columns["ScheduledDateTime"]
                                    .DefaultCellStyle.Format =
                                    "dd MMM yyyy HH:mm";
                            }

                            if (dgvDashboard.Columns["BookingStatus"] != null)
                            {
                                dgvDashboard.Columns["BookingStatus"].HeaderText =
                                    "Status";
                            }
                        }
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
        // CARD 1 - STUDENTS
        // ==========================================
        private void pnlCard1_Click(object sender, EventArgs e)
        {
            btnManageStudents_Click_1(sender, e);
        }

        private void lblCard1Title_Click(object sender, EventArgs e)
        {
            btnManageStudents_Click_1(sender, e);
        }

        private void lblCard1Value_Click(object sender, EventArgs e)
        {
            btnManageStudents_Click_1(sender, e);
        }

        // ==========================================
        // CARD 2 - INSTRUCTORS
        // ==========================================
        private void pnlCard2_Click(object sender, EventArgs e)
        {
            btnManageInstructors_Click_1(sender, e);
        }

        private void lblCard2Title_Click(object sender, EventArgs e)
        {
            btnManageInstructors_Click_1(sender, e);
        }

        private void lblCard2Value_Click(object sender, EventArgs e)
        {
            btnManageInstructors_Click_1(sender, e);
        }

        // ==========================================
        // CARD 3 - TOTAL REVENUE
        // ==========================================
        private void pnlCard3_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Hide();
        }

        private void lblCard3Title_Click(object sender, EventArgs e)
        {
            pnlCard3_Click(sender, e);
        }

        private void lblCard3Value_Click(object sender, EventArgs e)
        {
            pnlCard3_Click(sender, e);
        }

        // ==========================================
        // CARD 4 - VEHICLES
        // ==========================================
        private void pnlCard4_Click(object sender, EventArgs e)
        {
            btnManageVehicles_Click(sender, e);
        }

        private void lblCard4Title_Click(object sender, EventArgs e)
        {
            btnManageVehicles_Click(sender, e);
        }

        private void lblCard4Value_Click(object sender, EventArgs e)
        {
            btnManageVehicles_Click(sender, e);
        }

        // ==========================================
        // STANDARD FORM METHODS
        // ==========================================
        private void button1_Click(object sender, EventArgs e) { }

        private void pnlCard1_Paint(object sender, PaintEventArgs e) { }

        private void pnlCard2_Paint(object sender, PaintEventArgs e) { }

        private void pnlCard3_Paint(object sender, PaintEventArgs e) { }

        private void pnlCard4_Paint(object sender, PaintEventArgs e) { }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e) { }

        private void lblWelcome_Click(object sender, EventArgs e) { }

        private void btnManageStudents_Click_1(object sender, EventArgs e)
        {
            RegisterStudentsForm stud = new RegisterStudentsForm();
            stud.Show();
            this.Hide();
        }

        private void btnManageInstructors_Click_1(object sender, EventArgs e)
        {
            Form ff = new ManageInstructors();
            ff.Show();
            this.Hide();
        }

        private void btnManageVehicles_Click(object sender, EventArgs e)
        {
            Form form = new ManageVehicle();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        // ==========================================
        // GENERATE REPORTS
        // ==========================================
        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            try
            {
                string reportsPath = Path.Combine(
                    Application.StartupPath,
                    "Reports",
                    "reports.pbix");

                if (!File.Exists(reportsPath))
                {
                    MessageBox.Show(
                        "Report file not found at:\n" + reportsPath +
                        "\n\nMake sure reports.pbix is in the Reports folder " +
                        "and set to 'Copy if newer'.",
                        "File Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Process.Start(reportsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not open report: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvDashboard_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        { }

        private void btnHelp_Click(object sender, EventArgs e) { }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e) { }

        private void linkLabel1_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
            this.Hide();
        }

        // ==========================================
        // DASHBOARD LAYOUT
        // ==========================================
        private void LayoutDashboard()
        {
            int leftMargin = 17;
            int topMargin = 45;
            int cardHeight = 115;
            int cardCount = 4;
            int spacing = 13;

            int availableWidth =
                pnlMainContent.Width -
                (leftMargin * 2) -
                (spacing * (cardCount - 1));

            int cardWidth = availableWidth / cardCount;

            pnlCard1.Location =
                new Point(leftMargin, topMargin);
            pnlCard1.Size =
                new Size(cardWidth, cardHeight);

            pnlCard2.Location =
                new Point(leftMargin + (cardWidth + spacing), topMargin);
            pnlCard2.Size =
                new Size(cardWidth, cardHeight);

            pnlCard3.Location =
                new Point(leftMargin + (cardWidth + spacing) * 2, topMargin);
            pnlCard3.Size =
                new Size(cardWidth, cardHeight);

            pnlCard4.Location =
                new Point(leftMargin + (cardWidth + spacing) * 3, topMargin);
            pnlCard4.Size =
                new Size(cardWidth, cardHeight);

            int dataTop = topMargin + cardHeight + 13;
            int dataHeight =
                pnlMainContent.Height - dataTop - 10;

            if (dataHeight < 80)
            {
                dataHeight = 80;
            }

            pnlDataGrid.Location =
                new Point(leftMargin, dataTop);

            pnlDataGrid.Size =
                new Size(
                    pnlMainContent.Width - leftMargin * 2,
                    dataHeight);

            dgvDashboard.Location = new Point(9, 31);

            dgvDashboard.Size =
                new Size(
                    pnlDataGrid.Width - 18,
                    pnlDataGrid.Height - 39);

            dgvDashboard.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pnlMainContent_Resize(object sender, EventArgs e)
        {
            LayoutDashboard();
        }

        // ==========================================
        // NEW STAFF SIGN UP
        // ==========================================
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                SignUpForm signUp = new SignUpForm();
                signUp.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "The Sign Up form is not yet created.\n" +
                    "Please add a form named 'SignUpForm' to your project.",
                    "Feature Pending",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ManagerForm_Load_1(object sender, EventArgs e)
        {
        }
    }
}
