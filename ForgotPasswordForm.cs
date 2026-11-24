
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Driving_school_login_form
{
    public partial class ForgotPasswordForm : Form
    {
        // DATABASE CONNECTION
        private string connectionString =
            ConfigurationManager.ConnectionStrings[
                "Driving_school_login_form.Properties.Settings.GroupWst27ConnectionString"
            ].ConnectionString;

        // BREVO SETTINGS
        private string brevoApiKey =
            ConfigurationManager.AppSettings["BrevoApiKey"];

        private string senderEmail = global::System.Environment.GetEnvironmentVariable("IKHWEZI_BREVO_EMAIL");

        // PASSWORD RESET VARIABLES
        private string verificationCode = "";
        private DateTime codeExpiry;
        private string staffEmail = "";

        // FORM CONSTRUCTOR
        public ForgotPasswordForm()
        {
            InitializeComponent();

            roundedTextBox2.UseSystemPasswordChar = true;
            roundedTextBox3.UseSystemPasswordChar = true;

            roundedTextBox4.Visible = false;
            roundedTextBox2.Visible = false;
            roundedTextBox3.Visible = false;

            roundedButton3.Visible = false;
            roundedButton2.Visible = false;

            btnShowPassword.Visible = false;
            btnShowConfirmPassword.Visible = false;

            lblInstructions.Text =
                "Enter your registered staff email address.";
        }

        // SEND VERIFICATION CODE
        private async void roundedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = roundedTextBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show(
                        "Please enter your staff email address.",
                        "Missing Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // CHECK IF STAFF EMAIL EXISTS
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query =
                        @"SELECT COUNT(*) FROM Admin_Staff
                          WHERE LOWER(LTRIM(RTRIM(StafEmailAddress))) = @Email";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email", email.ToLower());

                        int count = Convert.ToInt32(
                            await command.ExecuteScalarAsync());

                        if (count == 0)
                        {
                            MessageBox.Show(
                                "No staff account was found with that email address.",
                                "Email Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }
                }

                staffEmail = email;

                // GENERATE SECURE 6-DIGIT CODE
                byte[] randomBytes = new byte[4];

                using (RandomNumberGenerator rng =
                    RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomBytes);
                }

                int randomNumber =
                    BitConverter.ToInt32(randomBytes, 0) & 0x7FFFFFFF;

                verificationCode =
                    (100000 + (randomNumber % 900000)).ToString();

                codeExpiry = DateTime.Now.AddMinutes(10);

                // SEND CODE TO TEST INBOX
                bool emailSent = await SendVerificationEmail(
                    senderEmail,
                    verificationCode);

                if (emailSent)
                {
                    MessageBox.Show(
                        "A verification code has been sent to the registered system email.",
                        "Verification Code Sent",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    roundedTextBox4.Visible = true;
                    roundedButton3.Visible = true;

                    lblInstructions.Text =
                        "Enter the verification code sent to the registered system email.";

                    roundedButton1.Enabled = false;
                }
                else
                {
                    MessageBox.Show(
                        "The verification email could not be sent.",
                        "Email Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SEND EMAIL USING BREVO API
        private async Task<bool> SendVerificationEmail(
            string recipientEmail,
            string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(brevoApiKey))
                {
                    MessageBox.Show(
                        "Brevo API key is missing from App.config.",
                        "Configuration Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add(
                        "api-key", brevoApiKey);

                    client.DefaultRequestHeaders.Add(
                        "accept", "application/json");

                    var emailData = new
                    {
                        sender = new
                        {
                            name = "Driving School",
                            email = senderEmail
                        },

                        to = new[]
                        {
                            new
                            {
                                email = recipientEmail
                            }
                        },

                        subject =
                            "Driving School - Password Reset Verification Code",

                        htmlContent = $@"
                            <html>
                            <body>
                                <h2>Password Reset</h2>

                                <p>
                                    A password reset request was made
                                    for your Driving School account.
                                </p>

                                <p>Your verification code is:</p>

                                <h1>{code}</h1>

                                <p>This code will expire in 10 minutes.</p>

                                <p>
                                    If you did not request a password reset,
                                    please ignore this email.
                                </p>
                            </body>
                            </html>"
                    };

                    string json =
                        JsonConvert.SerializeObject(emailData);

                    using (StringContent content =
                        new StringContent(
                            json,
                            Encoding.UTF8,
                            "application/json"))
                    {
                        HttpResponseMessage response =
                            await client.PostAsync(
                                "https://api.brevo.com/v3/smtp/email",
                                content);

                        string responseBody =
                            await response.Content.ReadAsStringAsync();

                        if (response.IsSuccessStatusCode)
                        {
                            return true;
                        }

                        MessageBox.Show(
                            "Brevo Error:\n\n" +
                            "Status: " + (int)response.StatusCode +
                            " " + response.StatusCode +
                            "\n\n" + responseBody,
                            "Email Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Email Exception:\n\n" + ex.Message,
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

        // VERIFY CODE
        private void roundedButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string enteredCode = roundedTextBox4.Text.Trim();

                if (string.IsNullOrWhiteSpace(enteredCode))
                {
                    MessageBox.Show(
                        "Please enter the verification code.",
                        "Missing Code",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (DateTime.Now > codeExpiry)
                {
                    MessageBox.Show(
                        "The verification code has expired. Please request a new code.",
                        "Code Expired",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    verificationCode = "";
                    roundedButton1.Enabled = true;
                    roundedTextBox4.Visible = false;
                    roundedButton3.Visible = false;

                    return;
                }

                if (enteredCode != verificationCode)
                {
                    MessageBox.Show(
                        "The verification code is incorrect.",
                        "Incorrect Code",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(
                    "Verification successful. You can now create a new password.",
                    "Verified",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                roundedTextBox4.Visible = false;
                roundedButton3.Visible = false;

                roundedTextBox2.Visible = true;
                roundedTextBox3.Visible = true;
                roundedButton2.Visible = true;

                btnShowPassword.Visible = true;
                btnShowConfirmPassword.Visible = true;

                lblInstructions.Text =
                    "Enter and confirm your new password.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // UPDATE PASSWORD
        private async void roundedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = roundedTextBox2.Text;
                string confirmPassword = roundedTextBox3.Text;

                if (string.IsNullOrWhiteSpace(newPassword) ||
                    string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show(
                        "Please enter and confirm your new password.",
                        "Missing Password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (newPassword.Length < 8)
                {
                    MessageBox.Show(
                        "Password must be at least 8 characters long.",
                        "Password Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!HasLetterAndDigit(newPassword))
                {
                    MessageBox.Show(
                        "Password must contain at least one letter and one number.",
                        "Password Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show(
                        "The passwords do not match.",
                        "Password Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                if (string.IsNullOrWhiteSpace(verificationCode) ||
                    DateTime.Now > codeExpiry)
                {
                    MessageBox.Show(
                        "Your verification has expired. Please request a new code.",
                        "Verification Expired",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(staffEmail))
                {
                    MessageBox.Show(
                        "Staff email could not be verified. Please start again.",
                        "Verification Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                // HASH PASSWORD USING THE SAME METHOD AS THE WEBSITE
                string passwordHash = PasswordHelper.Hash(newPassword);

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query =
                        @"UPDATE Admin_Staff
                          SET PasswordHash = @Password
                          WHERE LOWER(LTRIM(RTRIM(StafEmailAddress))) = @Email";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Password", passwordHash);

                        command.Parameters.AddWithValue(
                            "@Email", staffEmail.Trim().ToLower());

                        int rowsAffected =
                            await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            // Prevent reuse of the verification code
                            verificationCode = "";
                            staffEmail = "";

                            MessageBox.Show(
                                "Your password has been successfully updated.",
                                "Password Updated",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "The password could not be updated.",
                                "Update Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // CHECK PASSWORD REQUIREMENTS
        private bool HasLetterAndDigit(string password)
        {
            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                    hasLetter = true;

                if (char.IsDigit(c))
                    hasDigit = true;
            }

            return hasLetter && hasDigit;
        }

        // BACK TO LOGIN
        private void linkBackToLogin_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // DESIGNER EVENT HANDLERS
        private void roundedButton1_Click_1(
            object sender,
            EventArgs e)
        {
            roundedButton1_Click(sender, e);
        }

        private void ForgotPasswordForm_Load(
            object sender,
            EventArgs e)
        {
            // Nothing needed here
        }

        private void btnShowPassword_Click(
            object sender,
            EventArgs e)
        {
            roundedTextBox2.UseSystemPasswordChar =
                !roundedTextBox2.UseSystemPasswordChar;
        }

        private void btnShowConfirmPassword_Click(
            object sender,
            EventArgs e)
        {
            roundedTextBox3.UseSystemPasswordChar =
                !roundedTextBox3.UseSystemPasswordChar;
        }

        private void linkBackToLogin_LinkClicked_1(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
