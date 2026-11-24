
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class InstructorVehicleSelection : Form
    {
        // DATABASE CONNECTION
        // Use your actual database connection from App.config.
        private readonly string ConnectionString =
            System.Configuration.ConfigurationManager
            .ConnectionStrings[
                "Driving_school_login_form.Properties.Settings.GroupWst27ConnectionString"
            ].ConnectionString;

        public InstructorVehicleSelection()
        {
            InitializeComponent();
            SetupDataGridViewStyles();
        }

        // DATAGRIDVIEW SETTINGS
        private void SetupDataGridViewStyles()
        {
            dataGridVehicle.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridVehicle.MultiSelect = false;
            dataGridVehicle.AllowUserToAddRows = false;
            dataGridVehicle.AllowUserToDeleteRows = false;
            dataGridVehicle.ReadOnly = true;

            dataGridInstructor.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridInstructor.MultiSelect = false;
            dataGridInstructor.AllowUserToAddRows = false;
            dataGridInstructor.AllowUserToDeleteRows = false;
            dataGridInstructor.ReadOnly = true;
        }

        // FORM LOAD
        private void InstructorVehicleSelection_Load(
            object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTime =
                    ParseSelectedDateTime();

                LoadAvailableResources(
                    selectedDateTime,
                    StudentData.PackageName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading selection form:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // COMBINE SELECTED DATE AND TIME
        private DateTime ParseSelectedDateTime()
        {
            DateTime baseDate = StudentData.Date.Date;

            string t = (StudentData.Time ?? "").Trim();

            if (DateTime.TryParse(t, out DateTime parsedTime))
            {
                return baseDate.Add(parsedTime.TimeOfDay);
            }

            if (TimeSpan.TryParse(t, out TimeSpan ts))
            {
                return baseDate.Add(ts);
            }

            return baseDate.AddHours(8);
        }

        // LOAD VEHICLES AND INSTRUCTORS
        public void LoadAvailableResources(
            DateTime selectedDateTime,
            string packageName)
        {
            using (SqlConnection conn =
                new SqlConnection(ConnectionString))
            {
                conn.Open();

                // ==========================================
                // LOAD AVAILABLE VEHICLES
                // ==========================================

                string vehicleQuery = @"
                    SELECT DISTINCT
                        v.VehicleID,
                        v.VehicleType,
                        v.TransmissionType
                    FROM Vehicles v
                    CROSS JOIN Packages p
                    WHERE p.PackageName = @PackageName
                    AND (
                        v.VehicleType = p.VehicleCategory
                        OR (p.VehicleCategory LIKE '%Light%'
                            AND v.VehicleType LIKE '%Light%')
                        OR (p.VehicleCategory LIKE '%Medium%'
                            AND v.VehicleType LIKE '%Medium%')
                        OR (p.VehicleCategory LIKE '%Heavy%'
                            AND v.VehicleType LIKE '%Heavy%')
                    )
                    AND NOT EXISTS (
                        SELECT 1
                        FROM Lesson l
                        WHERE l.VehicleID = v.VehicleID
                        AND l.LessonDateTime = @SelectedDateTime
                        AND l.Status IN
                            ('Pending', 'Confirmed', 'Rescheduled')
                    )
                    AND NOT EXISTS (
                        SELECT 1
                        FROM Booking b
                        WHERE b.VehicleID = v.VehicleID
                        AND b.ScheduledDateTime = @SelectedDateTime
                        AND b.BookingStatus IN
                            ('Pending', 'Confirmed')
                    )
                    ORDER BY v.VehicleID";

                using (SqlCommand cmdVehicles =
                    new SqlCommand(vehicleQuery, conn))
                {
                    cmdVehicles.Parameters.AddWithValue(
                        "@PackageName", packageName);

                    cmdVehicles.Parameters.AddWithValue(
                        "@SelectedDateTime", selectedDateTime);

                    SqlDataAdapter daVehicles =
                        new SqlDataAdapter(cmdVehicles);

                    DataTable dtVehicles = new DataTable();

                    daVehicles.Fill(dtVehicles);

                    dataGridVehicle.DataSource = dtVehicles;
                }

                // ==========================================
                // LOAD INSTRUCTORS - DIAGNOSTIC VERSION
                // ==========================================

                // Temporarily load all instructors.
                // This removes the package and availability
                // filters so we can identify the problem.

                string instructorQuery = @"
                    SELECT
                        InstruEmailAddress,
                        Name,
                        Surname,
                        YearsOfExperience,
                        LicenceType,
                        Specialization
                    FROM Instructor
                    ORDER BY Name";

                using (SqlCommand cmdInstructors =
                    new SqlCommand(instructorQuery, conn))
                {
                    SqlDataAdapter daInstructors =
                        new SqlDataAdapter(cmdInstructors);

                    DataTable dtInstructors = new DataTable();

                    daInstructors.Fill(dtInstructors);

                    dataGridInstructor.DataSource = dtInstructors;

                    if (dtInstructors.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No instructors were found in the Instructor table.",
                            "No Instructors",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }

                // ==========================================
                // CHECK VEHICLE AVAILABILITY
                // ==========================================

                if (dataGridVehicle.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No vehicles available for this package at the selected date/time.",
                        "No Vehicles",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        // CONTINUE TO CONFIRM BOOKING
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridVehicle.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a vehicle from the list.",
                    "Vehicle Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dataGridVehicle.Focus();
                return;
            }

            if (dataGridInstructor.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select an instructor from the list.",
                    "Instructor Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                dataGridInstructor.Focus();
                return;
            }

            string selectedVehicle =
                dataGridVehicle.SelectedRows[0]
                .Cells["VehicleID"].Value?.ToString();

            string selectedInstructor =
                dataGridInstructor.SelectedRows[0]
                .Cells["InstruEmailAddress"].Value?.ToString();

            if (string.IsNullOrEmpty(selectedVehicle))
            {
                MessageBox.Show(
                    "Could not read the vehicle selection.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrEmpty(selectedInstructor))
            {
                MessageBox.Show(
                    "Could not read the instructor selection.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            StudentData.VehicleID = selectedVehicle;
            StudentData.InstructorEmail = selectedInstructor;

            ConfirmBooking ff = new ConfirmBooking();

            ff.Show();

            this.Hide();
        }

        // GO BACK TO SCHEDULE
        private void button1_Click(object sender, EventArgs e)
        {
            Schedule scheduleForm = new Schedule();

            scheduleForm.Show();

            this.Hide();
        }

        // DESIGNER EVENT HANDLERS
        private void dataGridInstructor_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridVehicle_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
