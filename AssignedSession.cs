using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class AssigndSession : Form
    {
        private string connectionString =
            global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private DataTable sessionsDataTable = new DataTable();

        public AssigndSession()
        {
            InitializeComponent();
        }

        private void AssigndSession_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + CurrentUser.FullName;
            this.Text = "My Assigned Sessions - " + CurrentUser.FullName;

            LoadAssignedSessions();
            FormatDataGridView();
        }

        // ==========================================
        // LOAD THIS INSTRUCTOR'S SESSIONS
        // ==========================================
        private void LoadAssignedSessions()
        {
            try
            {
                string query = @"
                    SELECT 
                        l.LessonID,
                        b.BookingID,
                        s.StudEmailAddress, 
                        s.Name + ' ' + s.Surname AS StudentName,
                        p.PackageName, 
                        l.LessonType, 
                        l.LessonDateTime, 
                        l.Duration, 
                        l.Status,
                        l.VehicleID
                    FROM Lesson l
                    INNER JOIN Booking  b ON l.BookingID = b.BookingID
                    INNER JOIN Students s ON b.StudEmailAddress = s.StudEmailAddress
                    LEFT  JOIN Packages p ON l.PackageID = p.PackageID
                    WHERE l.InstruEmailAddress = @InstructorEmail
                    ORDER BY l.LessonDateTime DESC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@InstructorEmail", CurrentUser.Email);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sessionsDataTable.Clear();
                    da.Fill(sessionsDataTable);

                    dataGridView1.DataSource = sessionsDataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // FORMAT GRID
        // ==========================================
        private void FormatDataGridView()
        {
            if (dataGridView1.DataSource == null) return;

            if (dataGridView1.Columns["LessonID"] != null) dataGridView1.Columns["LessonID"].Visible = false;
            if (dataGridView1.Columns["BookingID"] != null) dataGridView1.Columns["BookingID"].Visible = false;

            if (dataGridView1.Columns["StudEmailAddress"] != null) dataGridView1.Columns["StudEmailAddress"].HeaderText = "Student Email";
            if (dataGridView1.Columns["StudentName"] != null) dataGridView1.Columns["StudentName"].HeaderText = "Student Name";
            if (dataGridView1.Columns["LessonDateTime"] != null) dataGridView1.Columns["LessonDateTime"].HeaderText = "Date & Time";
            if (dataGridView1.Columns["VehicleID"] != null) dataGridView1.Columns["VehicleID"].HeaderText = "Vehicle";
            if (dataGridView1.Columns["PackageName"] != null) dataGridView1.Columns["PackageName"].HeaderText = "Package";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        // ==========================================
        // REAL-TIME SEARCH
        // ==========================================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().Replace("'", "''");

            if (searchTerm.Length > 0)
            {
                string filter = $@"
                    StudentName LIKE '%{searchTerm}%' OR 
                    StudEmailAddress LIKE '%{searchTerm}%' OR 
                    Status LIKE '%{searchTerm}%' OR 
                    LessonType LIKE '%{searchTerm}%' OR
                    PackageName LIKE '%{searchTerm}%'";

                sessionsDataTable.DefaultView.RowFilter = filter;
            }
            else
            {
                sessionsDataTable.DefaultView.RowFilter = string.Empty;
            }
        }

        // ==========================================
        // BACK
        // ==========================================
        private void btnBack_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reserved
        }

        private void panelTop_Paint(object sender, PaintEventArgs e) { }
    }
}