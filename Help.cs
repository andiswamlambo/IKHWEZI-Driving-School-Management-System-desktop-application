using Driving_school_login_form;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_School_System_Forms
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            SetupGrid();
            LoadHelpData();
        }

        private void SetupGrid()
        {
            dgvHelp.AutoGenerateColumns = false;
            dgvHelp.Columns.Clear();

            dgvHelp.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Topic",
                HeaderText = "Topic",
                Name = "Topic",
                Width = 180,
                DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F, FontStyle.Bold) }
            });
            dgvHelp.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description",
                Name = "Description",
                Width = 400
            });
            dgvHelp.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Location",
                HeaderText = "Where to Find",
                Name = "Location",
                Width = 180
            });

            // Style
            dgvHelp.EnableHeadersVisualStyles = false;
            dgvHelp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dgvHelp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHelp.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvHelp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvHelp.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvHelp.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgvHelp.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHelp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            dgvHelp.GridColor = Color.FromArgb(189, 195, 199);
            dgvHelp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHelp.BorderStyle = BorderStyle.None;
            dgvHelp.RowHeadersVisible = false;
            dgvHelp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHelp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHelp.ReadOnly = true;
            dgvHelp.AllowUserToAddRows = false;
            dgvHelp.MultiSelect = false;
            dgvHelp.RowTemplate.Height = 50;
            dgvHelp.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void LoadHelpData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Topic", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Location", typeof(string));

            // ── Getting Started ──
            dt.Rows.Add(
                "Getting Started",
                "The Manager Dashboard shows key statistics: total students, instructors, lessons, and vehicles. Click any card to navigate to the relevant management page.",
                "Dashboard (Home)"
            );
            dt.Rows.Add(
                "Dashboard Cards",
                "Click on any card (Students, Instructors, Lessons, Vehicles) to open the corresponding management form quickly.",
                "Dashboard Cards"
            );
            dt.Rows.Add(
                "Recent Bookings",
                "The dashboard grid shows the 10 most recent bookings with student name, package, date, and status.",
                "Dashboard Grid"
            );

            // ── Student Management ──
            dt.Rows.Add(
                "Add a Student",
                "Navigate to Manage Students from the sidebar. Fill in Name, Surname, Email, Phone, and Address. Click 'Add' to register. The email must be unique.",
                "Sidebar → Manage Students"
            );
            dt.Rows.Add(
                "Update Student",
                "Select a student row in the grid. Their details populate the form. Edit the fields and click 'Update'. Email (primary key) cannot be changed.",
                "Manage Students → Click Row → Update"
            );
            dt.Rows.Add(
                "Delete Student",
                "Select a student row in the grid and click 'Delete'. You will be asked to confirm. Note: students linked to bookings cannot be deleted.",
                "Manage Students → Click Row → Delete"
            );
            dt.Rows.Add(
                "Search Students",
                "Type a name, email, or phone number in the search box. The grid filters in real-time as you type.",
                "Manage Students → Search Box"
            );

            // ── Instructor Management ──
            dt.Rows.Add(
                "Add an Instructor",
                "Navigate to Manage Instructors. Fill in Email, Name, Surname, Phone, Address, Years of Experience, Licence Type, and Specialization. Click 'Add Instructor'.",
                "Sidebar → Manage Instructors"
            );
            dt.Rows.Add(
                "Licence Types",
                "Instructors must have a valid driving licence. Options: Code 8 (light vehicles), Code 10 (medium trucks), Code 14 (heavy trucks).",
                "Manage Instructors → Licence Type"
            );
            dt.Rows.Add(
                "Update Instructor",
                "Click a row in the grid to load instructor details. Edit fields and click 'Update'. Email cannot be changed after creation.",
                "Manage Instructors → Click Row → Update"
            );
            dt.Rows.Add(
                "Delete Instructor",
                "Select an instructor and click 'Delete'. Instructors assigned to active lessons cannot be removed.",
                "Manage Instructors → Click Row → Delete"
            );

            // ── Vehicle Management ──
            dt.Rows.Add(
                "Add a Vehicle",
                "Navigate to Manage Vehicles. Enter the Number Plate (e.g., CA 321-654), select Vehicle Type and Transmission (Manual/Automatic). Click 'Add Vehicle'.",
                "Sidebar → Manage Vehicles"
            );
            dt.Rows.Add(
                "Vehicle Types",
                "Vehicle types must match package categories: Light Motor Vehicle, Light Vehicle, Medium Truck, Heavy Truck.",
                "Manage Vehicles → Vehicle Type"
            );
            dt.Rows.Add(
                "Update Vehicle",
                "Click a row in the grid. Edit Vehicle Type or Transmission. Number plate (primary key) cannot be changed.",
                "Manage Vehicles → Click Row → Update"
            );
            dt.Rows.Add(
                "Delete Vehicle",
                "Select a vehicle and click 'Delete'. Vehicles assigned to scheduled lessons cannot be removed.",
                "Manage Vehicles → Click Row → Delete"
            );

            // ── Booking Flow ──
            dt.Rows.Add(
                "New Booking",
                "Navigate to Make Booking → New Booking. Enter student details, select a package, and click Continue.",
                "Sidebar → Make Booking → New Booking"
            );
            dt.Rows.Add(
                "Schedule a Lesson",
                "After entering student details, select a date, time slot, and lesson type. Green slots are available, red are taken.",
                "Booking Flow → Schedule"
            );
            dt.Rows.Add(
                "Select Vehicle & Instructor",
                "After scheduling, select a vehicle and instructor from the available options shown in the grid.",
                "Booking Flow → Vehicle/Instructor"
            );
            dt.Rows.Add(
                "Confirm Booking",
                "Review all details on the confirmation page. Click 'Confirm' to save the booking to the database.",
                "Booking Flow → Confirm"
            );

            // ── Reports ──
            dt.Rows.Add(
                "Generate Reports",
                "Click 'Generate Reports' in the sidebar to access financial reports, booking summaries, and instructor activity.",
                "Sidebar → Generate Reports"
            );

            // ── Troubleshooting ──
            dt.Rows.Add(
                "Foreign Key Errors",
                "If you see a constraint error when deleting, the record is linked to other data (e.g., a vehicle linked to a lesson). Remove the linked records first.",
                "Any Management Form"
            );
            dt.Rows.Add(
                "Duplicate Key Errors",
                "This means a record with the same ID or email already exists. Use a different identifier.",
                "Add Operations"
            );
            dt.Rows.Add(
                "Database Connection",
                "The system connects to a remote SQL Server. If data doesn't load, check your internet connection or contact IT support.",
                "System-wide"
            );
            dt.Rows.Add(
                "Logout",
                "Click the red 'LOGOUT' button at the bottom of the sidebar to return to the login screen.",
                "Sidebar → Logout"
            );

            dgvHelp.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
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
                    // Fallback — go back to login if role is unknown
                    targetForm = new FormLogin();
                    break;
            }
            targetForm.Show();
            this.Hide();
        }

        private void lblHeaderTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}