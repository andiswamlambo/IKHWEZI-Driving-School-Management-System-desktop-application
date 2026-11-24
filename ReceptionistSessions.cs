using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class ReceptionistSessions : Form
    {
        private string connectionString =
            global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private DataTable sessionsDataTable = new DataTable();

        public ReceptionistSessions()
        {
            InitializeComponent();
        }

        private void ReceptionistSessions_Load(object sender, EventArgs e)
        {
            LoadAssignedSessions();
            FormatDataGridView();
        }

        // ==========================================
        // LOAD SESSIONS
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
                        s.Name + ' ' + s.Surname AS FullNames,
                        p.PackageName, 
                        l.LessonType, 
                        l.LessonDateTime, 
                        l.Duration, 
                        l.Status,
                        i.InstruEmailAddress, 
                        l.VehicleID
                    FROM Lesson l
                    INNER JOIN Booking  b ON l.BookingID = b.BookingID
                    INNER JOIN Students s ON b.StudEmailAddress = s.StudEmailAddress
                    LEFT  JOIN Instructor i ON l.InstruEmailAddress = i.InstruEmailAddress
                    LEFT  JOIN Packages  p ON l.PackageID = p.PackageID
                    ORDER BY l.LessonDateTime DESC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
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
            if (dataGridView1.Columns["FullNames"] != null) dataGridView1.Columns["FullNames"].HeaderText = "Student Name";
            if (dataGridView1.Columns["InstruEmailAddress"] != null) dataGridView1.Columns["InstruEmailAddress"].HeaderText = "Instructor Email";
            if (dataGridView1.Columns["LessonDateTime"] != null) dataGridView1.Columns["LessonDateTime"].HeaderText = "Date & Time";
            if (dataGridView1.Columns["VehicleID"] != null) dataGridView1.Columns["VehicleID"].HeaderText = "Vehicle";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        // ==========================================
        // SEARCH
        // ==========================================
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim().Replace("'", "''");

            if (searchTerm.Length > 0)
            {
                string filter = $@"
                    FullNames LIKE '%{searchTerm}%' OR 
                    StudEmailAddress LIKE '%{searchTerm}%' OR 
                    Status LIKE '%{searchTerm}%' OR 
                    LessonType LIKE '%{searchTerm}%' OR
                    InstruEmailAddress LIKE '%{searchTerm}%'";

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
        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistForm receptionistform = new ReceptionistForm();
            receptionistform.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panelTop_Paint(object sender, PaintEventArgs e) { }
    }
}