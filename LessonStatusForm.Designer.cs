
using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;

namespace Driving_school_login_form
{
    public partial class LessonStatusForm : Form
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings[
                "Driving_school_login_form.Properties.Settings.GroupWst27ConnectionString"].ConnectionString;

        public LessonStatusForm()
        {
            InitializeComponent();
        }

        // ==========================================
        // FORM LOAD
        // ==========================================
        private void LessonStatusForm_Load(object sender, EventArgs e)
        {
            LoadStudents();

            txtCurrentStatus.Clear();
            lblMessage.Text = "";
            cmbNewStatus.SelectedIndex = -1;
            pnlReschedule.Visible = false;
        }

        // ==========================================
        // LOAD STUDENTS WITH LESSONS ONLY
        // ==========================================
        private void LoadStudents()
        {
            try
            {
                string query = @"
                    SELECT
                        b.StudEmailAddress,

                        CASE
                            WHEN @ShowStudentNumber = 1 THEN
                                b.StudEmailAddress +
                                ' (Stud No: ' +
                                COALESCE(
                                    (
                                        SELECT TOP 1
                                            CONVERT(varchar(10), s.StudNumber)
                                        FROM Students s
                                        WHERE LOWER(LTRIM(RTRIM(s.StudEmailAddress))) =
                                              LOWER(LTRIM(RTRIM(b.StudEmailAddress)))
                                    ),
                                    'N/A'
                                ) + ')'
                            ELSE
                                b.StudEmailAddress
                        END AS StudentDisplay

                    FROM Booking b

                    WHERE b.StudEmailAddress IS NOT NULL
                      AND LTRIM(RTRIM(b.StudEmailAddress)) <> ''

                      AND EXISTS
                      (
                          SELECT 1
                          FROM Lesson l
                          WHERE l.BookingID = b.BookingID
                      )

                    GROUP BY b.StudEmailAddress

                    ORDER BY b.StudEmailAddress";

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@ShowStudentNumber",
                        chkShowStudentNumber.Checked ? 1 : 0);

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbStudents.DataSource = null;

                    cmbStudents.DisplayMember = "StudentDisplay";
                    cmbStudents.ValueMember = "StudEmailAddress";
                    cmbStudents.DataSource = dt;

                    cmbStudents.SelectedIndex = -1;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show(
                            "No students with recorded lessons were found.",
                            "Students",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading students:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TOGGLE STUDENT NUMBER DISPLAY
        // ==========================================
        private void chkShowStudentNumber_CheckedChanged(
            object sender, EventArgs e)
        {
            string previousEmail = null;

            if (cmbStudents.SelectedValue != null &&
                !(cmbStudents.SelectedValue is DataRowView))
            {
                previousEmail =
                    cmbStudents.SelectedValue.ToString();
            }

            LoadStudents();

            if (!string.IsNullOrEmpty(previousEmail))
            {
                cmbStudents.SelectedValue = previousEmail;
            }
        }

        // ==========================================
        // LOAD LESSONS FOR SELECTED STUDENT
        // ==========================================
        private void cmbStudents_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            try
            {
                if (cmbStudents.SelectedValue == null ||
                    cmbStudents.SelectedValue is DataRowView)
                {
                    return;
                }

                string studentEmail =
                    cmbStudents.SelectedValue.ToString();

                string query = @"
                    SELECT
                        l.LessonID,
                        l.LessonType + ' - ' +
                        CONVERT(varchar(16), l.LessonDateTime, 120)
                        AS LessonDisplay

                    FROM Lesson l

                    INNER JOIN Booking b
                        ON l.BookingID = b.BookingID

                    WHERE LOWER(LTRIM(RTRIM(b.StudEmailAddress))) =
                          LOWER(LTRIM(RTRIM(@Email)))

                    ORDER BY l.LessonDateTime";

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@Email", studentEmail);

                    SqlDataAdapter da =
                        new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbLessons.DataSource = null;
                    cmbLessons.DisplayMember = "LessonDisplay";
                    cmbLessons.ValueMember = "LessonID";
                    cmbLessons.DataSource = dt;

                    cmbLessons.SelectedIndex = -1;

                    txtCurrentStatus.Clear();
                    cmbNewStatus.SelectedIndex = -1;
                    cmbNewStatus.Enabled = true;
                    btnUpdateStatus.Enabled = true;
                    pnlReschedule.Visible = false;

                    if (dt.Rows.Count == 0)
                    {
                        lblMessage.ForeColor = Color.DarkOrange;
                        lblMessage.Text =
                            "No lessons were found for this student.";
                    }
                    else
                    {
                        lblMessage.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading lessons:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // SHOW CURRENT STATUS
        // ==========================================
        private void cmbLessons_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            try
            {
                if (cmbLessons.SelectedValue == null ||
                    cmbLessons.SelectedValue is DataRowView)
                {
                    return;
                }

                int lessonID =
                    Convert.ToInt32(cmbLessons.SelectedValue);

                string query =
                    "SELECT Status FROM Lesson WHERE LessonID = @LessonID";

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@LessonID", lessonID);

                    conn.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        string currentStatus = result.ToString();

                        txtCurrentStatus.Text = currentStatus;

                        if (currentStatus == "Completed")
                        {
                            cmbNewStatus.Enabled = false;
                            btnUpdateStatus.Enabled = false;
                            pnlReschedule.Visible = false;

                            lblMessage.ForeColor = Color.DarkGray;
                            lblMessage.Text =
                                "Completed lessons are locked and cannot be modified.";
                        }
                        else
                        {
                            cmbNewStatus.Enabled = true;
                            btnUpdateStatus.Enabled = true;
                            lblMessage.Text = "";
                        }
                    }
                    else
                    {
                        txtCurrentStatus.Text = "No Status Set";
                        cmbNewStatus.Enabled = true;
                        btnUpdateStatus.Enabled = true;
                    }
                }

                cmbNewStatus.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error fetching status:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // SHOW/HIDE RESCHEDULE PANEL
        // ==========================================
        private void cmbNewStatus_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (cmbNewStatus.Text == "Rescheduled")
            {
                pnlReschedule.Visible = true;

                lblRescheduleInfo.Text =
                    "Select a proposed new date and time. " +
                    "The student must confirm this change.";

                dtpRescheduleDate.MinDate =
                    DateTime.Today.AddDays(1);

                dtpRescheduleDate.Value =
                    DateTime.Today.AddDays(1);
            }
            else
            {
                pnlReschedule.Visible = false;
            }
        }

        // ==========================================
        // UPDATE STATUS ONLY
        // ==========================================
        private void btnUpdateStatus_Click(
            object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            if (cmbLessons.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a lesson.");
                return;
            }

            if (cmbNewStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a new status.");
                return;
            }

            if (cmbNewStatus.Text == "Rescheduled")
            {
                MessageBox.Show(
                    "Please use the Reschedule Lesson button below.",
                    "Action Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (txtCurrentStatus.Text == "Completed")
            {
                MessageBox.Show(
                    "Cannot modify a completed lesson.",
                    "Action Restricted",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                return;
            }

            try
            {
                int lessonID =
                    Convert.ToInt32(cmbLessons.SelectedValue);

                string newStatus =
                    cmbNewStatus.SelectedItem.ToString();

                string query = @"
                    UPDATE Lesson
                    SET Status = @Status
                    WHERE LessonID = @LessonID
                    AND Status <> 'Completed'";

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@Status", newStatus);

                    cmd.Parameters.AddWithValue(
                        "@LessonID", lessonID);

                    conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        txtCurrentStatus.Text = newStatus;

                        lblMessage.ForeColor = Color.Green;
                        lblMessage.Text =
                            "Status updated successfully!";

                        MessageBox.Show(
                            "Lesson status updated successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        if (newStatus == "Completed")
                        {
                            cmbNewStatus.Enabled = false;
                            btnUpdateStatus.Enabled = false;

                            lblMessage.Text =
                                "Completed lessons are locked.";
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "No lesson was updated. It may already be completed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // SEND RESCHEDULE EMAIL THROUGH BREVO
        // ==========================================
        private async Task<bool> SendRescheduleEmailAsync(
            int lessonID,
            DateTime newDateTime,
            string studentEmail,
            Guid confirmationToken)
        {
            try
            {
                string apiKey =
                    ConfigurationManager.AppSettings["BrevoApiKey"];

                string baseUrl =
                    ConfigurationManager.AppSettings[
                        "RescheduleResponseBaseUrl"];

                if (string.IsNullOrWhiteSpace(apiKey))
                {
                    MessageBox.Show(
                        "Brevo API key was not found in App.config.");

                    return false;
                }

                if (string.IsNullOrWhiteSpace(baseUrl) ||
                    baseUrl.Contains("YOUR-APP"))
                {
                    MessageBox.Show(
                        "Please configure the actual Azure response URL " +
                        "in App.config before sending reschedule emails.");

                    return false;
                }

                if (string.IsNullOrWhiteSpace(studentEmail))
                {
                    MessageBox.Show(
                        "The selected student's email address is missing.");

                    return false;
                }

                string token = confirmationToken.ToString("D");

                string separator =
                    baseUrl.Contains("?") ? "&" : "?";

                string acceptUrl =
                    baseUrl + separator +
                    "token=" + Uri.EscapeDataString(token) +
                    "&choice=accept";

                string declineUrl =
                    baseUrl + separator +
                    "token=" + Uri.EscapeDataString(token) +
                    "&choice=decline";

                string safeStudentEmail =
                    System.Net.WebUtility.HtmlEncode(studentEmail);

                string safeAcceptUrl =
                    System.Net.WebUtility.HtmlEncode(acceptUrl);

                string safeDeclineUrl =
                    System.Net.WebUtility.HtmlEncode(declineUrl);

                var emailData = new
                {
                    sender = new
                    {
                        name = "Ikhwezi Driving School",
                        email = global::System.Environment.GetEnvironmentVariable("IKHWEZI_BREVO_EMAIL")
                    },

                    // Send to the selected student's registered email
                    to = new[]
                    {
                        new
                        {
                            email = studentEmail.Trim()
                        }
                    },

                    subject = "Please Confirm Your Driving Lesson Reschedule",

                    htmlContent = $@"
                    <html>
                    <body style='font-family:Arial,sans-serif;'>

                        <h2>Driving Lesson Reschedule</h2>

                        <p>Hello,</p>

                        <p>A new date and time have been proposed
                        for your driving lesson.</p>

                        <p>
                            <b>Lesson ID:</b> {lessonID}<br/>
                            <b>Registered student email:</b>
                            {safeStudentEmail}<br/>
                            <b>Proposed date:</b>
                            {newDateTime:dd MMMM yyyy}<br/>
                            <b>Proposed time:</b>
                            {newDateTime:HH:mm}
                        </p>

                        <p>Please select your response:</p>

                        <p>
                            <a href='{safeAcceptUrl}'
                               style='background-color:#16834A;
                               color:white;padding:12px 20px;
                               text-decoration:none;border-radius:5px;'>
                               Accept Proposed Date
                            </a>
                        </p>

                        <p>
                            <a href='{safeDeclineUrl}'
                               style='background-color:#B83232;
                               color:white;padding:12px 20px;
                               text-decoration:none;border-radius:5px;'>
                               Decline Proposed Date
                            </a>
                        </p>

                        <p>
                            This proposal expires in 7 days.
                        </p>

                        <p>
                            Regards,<br/>
                            Ikhwezi Driving School
                        </p>

                    </body>
                    </html>"
                };

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add(
                        "api-key", apiKey);

                    client.DefaultRequestHeaders.Add(
                        "accept", "application/json");

                    string json =
                        JsonConvert.SerializeObject(emailData);

                    StringContent content =
                        new StringContent(
                            json,
                            Encoding.UTF8,
                            "application/json");

                    HttpResponseMessage response =
                        await client.PostAsync(
                            "https://api.brevo.com/v3/smtp/email",
                            content);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }

                    string error =
                        await response.Content.ReadAsStringAsync();

                    MessageBox.Show(
                        "Brevo could not send the email:\n" + error,
                        "Email Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Email error:\n" + ex.Message,
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        // ==========================================
        // CREATE PENDING RESCHEDULE REQUEST
        // ==========================================
        private async void btnReschedule_Click(
            object sender, EventArgs e)
        {
            if (cmbStudents.SelectedValue == null ||
                cmbStudents.SelectedValue is DataRowView)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            if (cmbLessons.SelectedValue == null ||
                cmbLessons.SelectedValue is DataRowView)
            {
                MessageBox.Show("Please select a valid lesson.");
                return;
            }

            if (txtCurrentStatus.Text == "Completed")
            {
                MessageBox.Show(
                    "Completed lessons cannot be rescheduled.");

                return;
            }

            btnReschedule.Enabled = false;

            try
            {
                int lessonID =
                    Convert.ToInt32(cmbLessons.SelectedValue);

                // This is the email belonging to the selected student
                string studentEmail =
                    cmbStudents.SelectedValue.ToString().Trim();

                if (string.IsNullOrWhiteSpace(studentEmail))
                {
                    MessageBox.Show(
                        "The selected student's email address is missing.");

                    return;
                }

                DateTime newDateTime =
                    dtpRescheduleDate.Value.Date +
                    dtpRescheduleTime.Value.TimeOfDay;

                if (newDateTime <= DateTime.Now)
                {
                    MessageBox.Show(
                        "Please select a future date and time.");

                    return;
                }

                Guid confirmationToken;

                DateTime expiresAt =
                    DateTime.Now.AddDays(7);

                // Create the pending request in the database
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction =
                        conn.BeginTransaction())
                    {
                        try
                        {
                            // Confirm lesson exists and is not completed
                            string checkQuery = @"
                                SELECT Status
                                FROM Lesson WITH (UPDLOCK, ROWLOCK)
                                WHERE LessonID = @LessonID";

                            SqlCommand checkCmd =
                                new SqlCommand(
                                    checkQuery, conn, transaction);

                            checkCmd.Parameters.AddWithValue(
                                "@LessonID", lessonID);

                            object statusResult =
                                checkCmd.ExecuteScalar();

                            if (statusResult == null ||
                                statusResult == DBNull.Value)
                            {
                                throw new Exception(
                                    "The selected lesson could not be found.");
                            }

                            if (statusResult.ToString() == "Completed")
                            {
                                throw new Exception(
                                    "Completed lessons cannot be rescheduled.");
                            }

                            // Expire any older pending proposals
                            string expireQuery = @"
                                UPDATE RescheduleConfirmation
                                SET ConfirmationStatus = 'Expired'
                                WHERE LessonID = @LessonID
                                AND ConfirmationStatus = 'Pending'";

                            SqlCommand expireCmd =
                                new SqlCommand(
                                    expireQuery, conn, transaction);

                            expireCmd.Parameters.AddWithValue(
                                "@LessonID", lessonID);

                            expireCmd.ExecuteNonQuery();

                            // Insert the new pending proposal
                            string insertQuery = @"
                                INSERT INTO RescheduleConfirmation
                                (
                                    LessonID,
                                    ProposedDateTime,
                                    ConfirmationStatus,
                                    CreatedAt,
                                    ExpiresAt
                                )
                                OUTPUT INSERTED.ConfirmationToken
                                VALUES
                                (
                                    @LessonID,
                                    @ProposedDateTime,
                                    'Pending',
                                    GETDATE(),
                                    @ExpiresAt
                                )";

                            SqlCommand insertCmd =
                                new SqlCommand(
                                    insertQuery, conn, transaction);

                            insertCmd.Parameters.AddWithValue(
                                "@LessonID", lessonID);

                            insertCmd.Parameters.AddWithValue(
                                "@ProposedDateTime", newDateTime);

                            insertCmd.Parameters.AddWithValue(
                                "@ExpiresAt", expiresAt);

                            object tokenResult =
                                insertCmd.ExecuteScalar();

                            confirmationToken =
                                (Guid)tokenResult;

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                // Send email to the selected student's registered address
                bool emailSent =
                    await SendRescheduleEmailAsync(
                        lessonID,
                        newDateTime,
                        studentEmail,
                        confirmationToken);

                if (emailSent)
                {
                    lblMessage.ForeColor = Color.DarkOrange;

                    lblMessage.Text =
                        "A new reschedule proposal is awaiting student confirmation.";

                    MessageBox.Show(
                        "The proposed date has been saved as Pending.\n\n" +
                        "The original lesson date has NOT been changed.\n\n" +
                        "The rescheduling notification was sent to:\n" +
                        studentEmail,
                        "Reschedule Proposal Sent",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;

                    lblMessage.Text =
                        "Proposal saved, but email notification failed.";

                    MessageBox.Show(
                        "The pending proposal was saved, but the email " +
                        "could not be sent.\n\nPlease check your Brevo configuration.",
                        "Email Notification Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                pnlReschedule.Visible = false;
                cmbNewStatus.SelectedIndex = -1;

                // Reload the lessons.
                // The original lesson date should still be displayed.
                cmbStudents_SelectedIndexChanged(
                    this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error creating reschedule proposal:\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnReschedule.Enabled = true;
            }
        }

        // ==========================================
        // BUTTON HOVER EFFECTS
        // ==========================================
        private void btnUpdateStatus_MouseEnter(
            object sender, EventArgs e)
        {
            btnUpdateStatus.BackColor =
                Color.FromArgb(0, 100, 190);
        }

        private void btnUpdateStatus_MouseLeave(
            object sender, EventArgs e)
        {
            btnUpdateStatus.BackColor =
                Color.FromArgb(0, 120, 215);
        }

        private void btnReschedule_MouseEnter(
            object sender, EventArgs e)
        {
            btnReschedule.BackColor =
                Color.FromArgb(30, 130, 50);
        }

        private void btnReschedule_MouseLeave(
            object sender, EventArgs e)
        {
            btnReschedule.BackColor =
                Color.FromArgb(40, 160, 60);
        }

        // ==========================================
        // BACK
        // ==========================================
        private void button1_Click(object sender, EventArgs e)
        {
            InstructorForm back = new InstructorForm();
            back.Show();
            this.Hide();
        }

        private void txtCurrentStatus_TextChanged(
            object sender, EventArgs e)
        {
        }
    }
}
