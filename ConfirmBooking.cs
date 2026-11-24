using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Driving_School_System_Forms;

namespace Driving_school_login_form
{
    public partial class ConfirmBooking : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public ConfirmBooking()
        {
            InitializeComponent();
        }

        private void ConfirmBooking_Load(object sender, EventArgs e)
        {
            lblStudentValue.Text = (StudentData.Name + " " + StudentData.Surname).Trim();
            lblEmailValue.Text = StudentData.Email ?? "";
            lblPackageValue.Text = StudentData.PackageName ?? "";
            lblDateTimeValue.Text = StudentData.Date.ToString("ddd, dd MMM yyyy") + " at " + StudentData.Time;
            lblDurationValue.Text = StudentData.Duration + " minutes";
            lblVehicleValue.Text = StudentData.VehicleID ?? "Not selected";
            lblInstructorValue.Text = StudentData.InstructorEmail ?? "Not selected";
            lblBookingDateValue.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm");
        }

        // Robustly combine StudentData.Date + StudentData.Time
        private DateTime ParseSelectedDateTime()
        {
            DateTime baseDate = StudentData.Date.Date;
            string t = (StudentData.Time ?? "").Trim();

            if (DateTime.TryParse(t, out DateTime parsedTime))
                return baseDate.Add(parsedTime.TimeOfDay);

            if (TimeSpan.TryParse(t, out TimeSpan ts))
                return baseDate.Add(ts);

            return baseDate.AddHours(8);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            roundedButton1.Enabled = false;
            roundedButton2.Enabled = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlTransaction tran = conn.BeginTransaction();

                    try
                    {
                        int packageId = StudentData.PackageID;
                        if (packageId <= 0)
                            throw new Exception("No package was selected. Please go back and pick a package.");

                        if (string.IsNullOrWhiteSpace(StudentData.Email))
                            throw new Exception("Student email is missing.");

                        if (string.IsNullOrWhiteSpace(StudentData.InstructorEmail))
                            throw new Exception("No instructor was selected.");

                        if (string.IsNullOrWhiteSpace(StudentData.VehicleID))
                            throw new Exception("No vehicle was selected.");

                        DateTime scheduledAt = ParseSelectedDateTime();

                        // ── 1. Ensure the student exists in Students table ──
                        EnsureStudentExists(conn, tran);

                        // ── 2. Resolve VehicleID (allow exact plate or fuzzy VehicleType) ──
                        string vehicleId = ResolveVehicleId(conn, tran, StudentData.VehicleID);

                        // ── 3. Insert Booking (with VehicleID column) ──
                        string bookingQuery =
                            "INSERT INTO Booking " +
                            "(BookingDate, StudEmailAddress, StafEmailAddress, BookingStatus, PackageID, ScheduledDateTime, VehicleID) " +
                            "VALUES " +
                            "(@BookingDate, @StudEmailAddress, @StafEmailAddress, @BookingStatus, @PackageID, @ScheduledDateTime, @VehicleID); " +
                            "SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdBooking = new SqlCommand(bookingQuery, conn, tran);
                        cmdBooking.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                        cmdBooking.Parameters.AddWithValue("@StudEmailAddress", StudentData.Email);
                        cmdBooking.Parameters.AddWithValue("@StafEmailAddress", StudentData.InstructorEmail);
                        cmdBooking.Parameters.AddWithValue("@BookingStatus", "Pending");
                        cmdBooking.Parameters.AddWithValue("@PackageID", packageId);
                        cmdBooking.Parameters.AddWithValue("@ScheduledDateTime", scheduledAt);
                        cmdBooking.Parameters.AddWithValue("@VehicleID", vehicleId);

                        int bookingId = Convert.ToInt32(cmdBooking.ExecuteScalar());

                        // ── 4. Insert Lesson ──
                        string lessonQuery =
                            "INSERT INTO Lesson " +
                            "(LessonType, Duration, Status, VehicleID, InstruEmailAddress, BookingID, PackageID, LessonDateTime) " +
                            "VALUES " +
                            "(@LessonType, @Duration, @Status, @VehicleID, @InstruEmailAddress, @BookingID, @PackageID, @LessonDateTime); " +
                            "SELECT SCOPE_IDENTITY();";

                        SqlCommand cmdLesson = new SqlCommand(lessonQuery, conn, tran);
                        cmdLesson.Parameters.AddWithValue("@LessonType", StudentData.LessonType ?? "Standard");
                        cmdLesson.Parameters.AddWithValue("@Duration", StudentData.Duration);
                        cmdLesson.Parameters.AddWithValue("@Status", "Pending");
                        cmdLesson.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmdLesson.Parameters.AddWithValue("@InstruEmailAddress", StudentData.InstructorEmail);
                        cmdLesson.Parameters.AddWithValue("@BookingID", bookingId);
                        cmdLesson.Parameters.AddWithValue("@PackageID", packageId);
                        cmdLesson.Parameters.AddWithValue("@LessonDateTime", scheduledAt);

                        int lessonId = Convert.ToInt32(cmdLesson.ExecuteScalar());

                        // ── 5. Insert LessonVehicle ──
                        string lessonVehicleQuery =
                            "INSERT INTO LessonVehicle (VehicleID, LessonID) " +
                            "VALUES (@VehicleID, @LessonID);";

                        SqlCommand cmdLessonVehicle = new SqlCommand(lessonVehicleQuery, conn, tran);
                        cmdLessonVehicle.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmdLessonVehicle.Parameters.AddWithValue("@LessonID", lessonId);
                        cmdLessonVehicle.ExecuteNonQuery();

                        tran.Commit();

                        StudentData.Status = "Pending";
                        StudentData.SaveBooking();

                        MessageBox.Show("Booking confirmed successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ReceptionistForm rf = new ReceptionistForm();
                        rf.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Error confirming booking:\n" + ex.Message,
                            "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            finally
            {
                UseWaitCursor = false;
                roundedButton1.Enabled = true;
                roundedButton2.Enabled = true;
            }
        }

        // ──────────────────────────────────────────────
        //  Ensure the student exists — insert if new
        // ──────────────────────────────────────────────
        private void EnsureStudentExists(SqlConnection conn, SqlTransaction tran)
        {
            string check = "SELECT COUNT(*) FROM Students WHERE StudEmailAddress = @Email";
            using (SqlCommand cmd = new SqlCommand(check, conn, tran))
            {
                cmd.Parameters.AddWithValue("@Email", StudentData.Email);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0) return;
            }

            // New student — insert with the new schema columns
            string insert = @"
                INSERT INTO Students
                    (StudEmailAddress, Name, Surname, PhoneNum, StreetAddress, Suburb, City, RegisterDate, Status)
                VALUES
                    (@Email, @Name, @Surname, @Phone, NULL, NULL, NULL, GETDATE(), 'Active')";

            using (SqlCommand cmd = new SqlCommand(insert, conn, tran))
            {
                cmd.Parameters.AddWithValue("@Email", StudentData.Email);
                cmd.Parameters.AddWithValue("@Name", StudentData.Name ?? "");
                cmd.Parameters.AddWithValue("@Surname", StudentData.Surname ?? "");
                cmd.Parameters.AddWithValue("@Phone",
                    string.IsNullOrWhiteSpace(StudentData.Phone) ? (object)DBNull.Value : StudentData.Phone);
                cmd.ExecuteNonQuery();
            }
        }

        private string ResolveVehicleId(SqlConnection conn, SqlTransaction tran, string vehicleInput)
        {
            // 1. Exact plate match
            using (SqlCommand cmd = new SqlCommand(
                "SELECT TOP 1 VehicleID FROM Vehicles WHERE VehicleID = @val", conn, tran))
            {
                cmd.Parameters.AddWithValue("@val", vehicleInput);
                object result = cmd.ExecuteScalar();
                if (result != null) return result.ToString();
            }

            // 2. Exact match on VehicleType
            using (SqlCommand cmd = new SqlCommand(
                "SELECT TOP 1 VehicleID FROM Vehicles WHERE VehicleType = @val", conn, tran))
            {
                cmd.Parameters.AddWithValue("@val", vehicleInput);
                object result = cmd.ExecuteScalar();
                if (result != null) return result.ToString();
            }

            // 3. Keyword match on VehicleType
            string keyword = vehicleInput.Contains("Light") ? "Light" :
                             vehicleInput.Contains("Medium") ? "Medium" :
                             vehicleInput.Contains("Heavy") ? "Heavy" :
                             vehicleInput;

            using (SqlCommand cmd = new SqlCommand(
                "SELECT TOP 1 VehicleID FROM Vehicles WHERE VehicleType LIKE '%' + @keyword + '%'", conn, tran))
            {
                cmd.Parameters.AddWithValue("@keyword", keyword);
                object result = cmd.ExecuteScalar();
                if (result != null) return result.ToString();
            }

            throw new Exception("No vehicle found matching '" + vehicleInput + "'.");
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            InstructorVehicleSelection vehicleInstructor = new InstructorVehicleSelection();
            vehicleInstructor.Show();
            this.Hide();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}