
using Driving_School_System_Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class FormLogin : Form
    {
        private string connstring =
            global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public FormLogin()
        {
            InitializeComponent();
        }

        // ==========================================
        // LOGIN BUTTON CLICK
        // ==========================================
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(roundedTextBox1.Text) ||
                string.IsNullOrWhiteSpace(roundedTextBox2.Text))
            {
                MessageBox.Show(
                    "Please enter both Email and Password.",
                    "Missing Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    string query = @"
                        SELECT Name, Surname, Role, PasswordHash
                        FROM Admin_Staff
                        WHERE StafEmailAddress = @email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@email", roundedTextBox1.Text.Trim());

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash =
                                    reader["PasswordHash"] == DBNull.Value
                                    ? null
                                    : reader["PasswordHash"].ToString();

                                // Verify using the same PBKDF2 method
                                // as the ASP.NET website.
                                if (!PasswordHelper.Verify(
                                    roundedTextBox2.Text, storedHash))
                                {
                                    MessageBox.Show(
                                        "Wrong Password or Username",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                                    return;
                                }

                                // Save logged-in user information
                                CurrentUser.Email =
                                    roundedTextBox1.Text.Trim();

                                CurrentUser.Name =
                                    reader["Name"].ToString();

                                CurrentUser.Surname =
                                    reader["Surname"].ToString();

                                CurrentUser.Role =
                                    reader["Role"].ToString().Trim();

                                // ==================================
                                // FORM NAVIGATION
                                // ==================================

                                Form targetForm;

                                string pendingFeature =
                                    CurrentUser.PendingFeature;

                                CurrentUser.PendingFeature = "";

                                if (pendingFeature == "BookSession")
                                {
                                    targetForm = new MakeBooking();
                                }
                                else if (pendingFeature == "VerifyPayment")
                                {
                                    targetForm = new VerifyPayments();
                                }
                                else
                                {
                                    string role =
                                        CurrentUser.Role.ToLowerInvariant();

                                    if (role == "receptionist")
                                    {
                                        targetForm = new ReceptionistForm();
                                    }
                                    else if (role == "instructor")
                                    {
                                        targetForm = new InstructorForm();
                                    }
                                    else if (role == "manager")
                                    {
                                        targetForm = new ManagerForm();
                                    }
                                    else
                                    {
                                        MessageBox.Show(
                                            "Unknown role assigned to this user: " +
                                            CurrentUser.Role,
                                            "Access Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);

                                        return;
                                    }
                                }

                                targetForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Wrong Password or Username",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // OTHER EVENTS
        // ==========================================

        private void Form1_Load(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void roundedTextBox1_Load(object sender, EventArgs e) { }

        // ==========================================
        // FORGOT PASSWORD
        // ==========================================

        private void linkLabel1_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm forgot = new ForgotPasswordForm();
            forgot.Show();
        }

        // ==========================================
        // SHOW / HIDE PASSWORD
        // ==========================================

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            roundedTextBox2.UseSystemPasswordChar =
                !roundedTextBox2.UseSystemPasswordChar;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
