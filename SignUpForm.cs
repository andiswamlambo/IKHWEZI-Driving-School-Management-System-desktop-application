using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class SignUpForm : Form
    {
        private string connstring =
            global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private ErrorProvider errorProvider = new ErrorProvider();
        private Color defaultBackColor;

        public SignUpForm()
        {
            InitializeComponent();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.BlinkRate = 0;

            defaultBackColor = txtEmail.BackColor;

            // Wire real-time validation
            txtEmail.TextChanged += ValidateEmail_RealTime;
            txtEmail.Leave += ValidateEmail_RealTime;

            txtName.TextChanged += ValidateName_RealTime;
            txtName.Leave += ValidateName_RealTime;

            txtSurname.TextChanged += ValidateSurname_RealTime;
            txtSurname.Leave += ValidateSurname_RealTime;

            txtPhone.TextChanged += ValidatePhone_RealTime;
            txtPhone.Leave += ValidatePhone_RealTime;

            txtPassword.TextChanged += ValidatePassword_RealTime;
            txtPassword.Leave += ValidatePassword_RealTime;

            txtConfirmPass.TextChanged += ValidateConfirmPass_RealTime;
            txtConfirmPass.Leave += ValidateConfirmPass_RealTime;

            txtExperience.TextChanged += ValidateExperience_RealTime;
            txtExperience.Leave += ValidateExperience_RealTime;

            cmbLicence.SelectedIndexChanged += ValidateLicence_RealTime;

            // Block garbage at keypress level
            txtName.KeyPress += txtName_KeyPress;
            txtSurname.KeyPress += txtSurname_KeyPress;
            txtPhone.KeyPress += txtPhone_KeyPress;
            txtExperience.KeyPress += txtExperience_KeyPress;
        }

        // ==========================================
        // HELPERS
        // ==========================================
        private void SetFieldError(Control ctrl, string message)
        {
            errorProvider.SetError(ctrl, message);
            ctrl.BackColor = string.IsNullOrEmpty(message)
                ? defaultBackColor
                : Color.MistyRose;
        }

        private void ClearFieldError(Control ctrl)
        {
            errorProvider.SetError(ctrl, string.Empty);
            ctrl.BackColor = defaultBackColor;
        }

        // ==========================================
        // REAL-TIME VALIDATORS
        // ==========================================
        private void ValidateEmail_RealTime(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                SetFieldError(txtEmail, "Email is required.");
                return;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtEmail.Text.Trim(), pattern))
                SetFieldError(txtEmail, "Enter a valid email (e.g. you@domain.com).");
            else
                ClearFieldError(txtEmail);
        }

        private void ValidateName_RealTime(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                SetFieldError(txtName, "Name is required.");
                return;
            }

            if (!Regex.IsMatch(txtName.Text.Trim(), @"^[a-zA-Z\s]+$"))
                SetFieldError(txtName, "Letters and spaces only.");
            else if (txtName.Text.Trim().Length < 2)
                SetFieldError(txtName, "Name must be at least 2 characters.");
            else
                ClearFieldError(txtName);
        }

        private void ValidateSurname_RealTime(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                SetFieldError(txtSurname, "Surname is required.");
                return;
            }

            if (!Regex.IsMatch(txtSurname.Text.Trim(), @"^[a-zA-Z\s]+$"))
                SetFieldError(txtSurname, "Letters and spaces only.");
            else if (txtSurname.Text.Trim().Length < 2)
                SetFieldError(txtSurname, "Surname must be at least 2 characters.");
            else
                ClearFieldError(txtSurname);
        }

        private void ValidatePhone_RealTime(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                SetFieldError(txtPhone, "Phone number is required.");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^0\d{9}$"))
                SetFieldError(txtPhone, "Must be 10 digits starting with 0.");
            else
                ClearFieldError(txtPhone);
        }

        private void ValidatePassword_RealTime(object sender, EventArgs e)
        {
            string pattern =
                @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&^#])[A-Za-z\d@$!%*?&^#]{7,}$";

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                SetFieldError(txtPassword, "Password is required.");
            }
            else if (!Regex.IsMatch(txtPassword.Text, pattern))
            {
                SetFieldError(txtPassword,
                    "Min 7 chars, 1 upper, 1 lower, 1 digit, 1 special.");
            }
            else
            {
                ClearFieldError(txtPassword);
            }

            if (!string.IsNullOrWhiteSpace(txtConfirmPass.Text))
                ValidateConfirmPass_RealTime(txtConfirmPass, EventArgs.Empty);
        }

        private void ValidateConfirmPass_RealTime(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                SetFieldError(txtConfirmPass, "Please confirm your password.");
                return;
            }

            if (txtConfirmPass.Text != txtPassword.Text)
                SetFieldError(txtConfirmPass, "Passwords do not match.");
            else
                ClearFieldError(txtConfirmPass);
        }

        private void ValidateExperience_RealTime(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem == null ||
                cmbRole.SelectedItem.ToString() != "Instructor")
            {
                ClearFieldError(txtExperience);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtExperience.Text))
            {
                SetFieldError(txtExperience, "Years of experience is required.");
                return;
            }

            double experience;
            if (!double.TryParse(txtExperience.Text.Trim(), out experience))
                SetFieldError(txtExperience, "Must be a valid number.");
            else if (experience < 0)
                SetFieldError(txtExperience, "Cannot be negative.");
            else if (experience > 60)
                SetFieldError(txtExperience, "Value seems unrealistic (>60).");
            else
                ClearFieldError(txtExperience);
        }

        private void ValidateLicence_RealTime(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem == null ||
                cmbRole.SelectedItem.ToString() != "Instructor")
            {
                ClearFieldError(cmbLicence);
                return;
            }

            if (cmbLicence.SelectedIndex == -1)
                SetFieldError(cmbLicence, "Select a licence type.");
            else
                ClearFieldError(cmbLicence);
        }

        // ==========================================
        // KEYPRESS GUARDS
        // ==========================================
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
                var ctrl = (Control)sender;
                ctrl.BackColor = Color.MistyRose;
                var timer = new Timer { Interval = 600 };
                timer.Tick += (s, ev) =>
                {
                    if (string.IsNullOrEmpty(errorProvider.GetError(ctrl)))
                        ctrl.BackColor = defaultBackColor;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtName_KeyPress(sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                txtPhone.BackColor = Color.MistyRose;
                var timer = new Timer { Interval = 600 };
                timer.Tick += (s, ev) =>
                {
                    if (string.IsNullOrEmpty(errorProvider.GetError(txtPhone)))
                        txtPhone.BackColor = defaultBackColor;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }

        private void txtExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
                txtExperience.BackColor = Color.MistyRose;
                var timer = new Timer { Interval = 600 };
                timer.Tick += (s, ev) =>
                {
                    if (string.IsNullOrEmpty(errorProvider.GetError(txtExperience)))
                        txtExperience.BackColor = defaultBackColor;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }

            if (e.KeyChar == '.' &&
                sender is TextBox tb &&
                tb.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        // ==========================================
        // TOGGLE INSTRUCTOR FIELDS
        // ==========================================
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isInstructor =
                cmbRole.SelectedItem != null &&
                cmbRole.SelectedItem.ToString() == "Instructor";

            lblLicence.Visible = isInstructor;
            cmbLicence.Visible = isInstructor;
            lblExperience.Visible = isInstructor;
            txtExperience.Visible = isInstructor;

            if (isInstructor)
            {
                lblPassword.Location = new Point(50, 433);
                txtPassword.Location = new Point(50, 450);
                lblConfirmPass.Location = new Point(50, 493);
                txtConfirmPass.Location = new Point(50, 510);
                btnSignUp.Location = new Point(50, 570);
                btnBack.Location = new Point(30, 630);
                this.ClientSize = new Size(500, 680);
            }
            else
            {
                lblPassword.Location = new Point(50, 283);
                txtPassword.Location = new Point(50, 300);
                lblConfirmPass.Location = new Point(50, 343);
                txtConfirmPass.Location = new Point(50, 360);
                btnSignUp.Location = new Point(50, 420);
                btnBack.Location = new Point(30, 480);
                this.ClientSize = new Size(500, 530);

                ClearFieldError(cmbLicence);
                ClearFieldError(txtExperience);
            }
        }

        // ==========================================
        // FINAL CHECK
        // ==========================================
        private bool AllFieldsValid()
        {
            ValidateEmail_RealTime(txtEmail, EventArgs.Empty);
            ValidateName_RealTime(txtName, EventArgs.Empty);
            ValidateSurname_RealTime(txtSurname, EventArgs.Empty);
            ValidatePhone_RealTime(txtPhone, EventArgs.Empty);
            ValidatePassword_RealTime(txtPassword, EventArgs.Empty);
            ValidateConfirmPass_RealTime(txtConfirmPass, EventArgs.Empty);

            if (cmbRole.SelectedIndex == -1)
                SetFieldError(cmbRole, "Please select a role.");
            else
                ClearFieldError(cmbRole);

            if (cmbRole.SelectedItem?.ToString() == "Instructor")
            {
                ValidateLicence_RealTime(cmbLicence, EventArgs.Empty);
                ValidateExperience_RealTime(txtExperience, EventArgs.Empty);
            }

            return string.IsNullOrEmpty(errorProvider.GetError(txtEmail)) &&
                   string.IsNullOrEmpty(errorProvider.GetError(txtName)) &&
                   string.IsNullOrEmpty(errorProvider.GetError(txtSurname)) &&
                   string.IsNullOrEmpty(errorProvider.GetError(txtPhone)) &&
                   string.IsNullOrEmpty(errorProvider.GetError(txtPassword)) &&
                   string.IsNullOrEmpty(errorProvider.GetError(txtConfirmPass)) &&
                   string.IsNullOrEmpty(errorProvider.GetError(cmbRole)) &&
                   (cmbRole.SelectedItem?.ToString() != "Instructor" ||
                       (string.IsNullOrEmpty(errorProvider.GetError(cmbLicence)) &&
                        string.IsNullOrEmpty(errorProvider.GetError(txtExperience))));
        }

        // ==========================================
        // SIGN UP
        // ==========================================
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!AllFieldsValid())
            {
                MessageBox.Show(
                    "Please fix the highlighted errors before continuing.",
                    "Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                FocusFirstError();
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connstring))
                {
                    conn.Open();

                    // A. Duplicate check — Admin_Staff
                    string checkQuery =
                        "SELECT COUNT(*) FROM Admin_Staff WHERE StafEmailAddress = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            SetFieldError(txtEmail,
                                "This email is already registered.");
                            MessageBox.Show(
                                "An account with this email already exists.",
                                "Duplicate Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // B. Insert into Admin_Staff.
                    //    Includes AdminStatus + EmploymentStartDate
                    //    (columns exist in your real table).
                    string insertAdminQuery =
                        @"INSERT INTO Admin_Staff
                            (StafEmailAddress, Name, Surname, Role,
                             AdminStatus, EmploymentStartDate, PasswordHash)
                          VALUES
                            (@Email, @Name, @Surname, @Role,
                             'Employed', GETDATE(), @Password)";

                    using (SqlCommand cmdAdmin = new SqlCommand(insertAdminQuery, conn))
                    {
                        cmdAdmin.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmdAdmin.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmdAdmin.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                        cmdAdmin.Parameters.AddWithValue("@Role", role);
                        cmdAdmin.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        cmdAdmin.ExecuteNonQuery();
                    }

                    // C. If Instructor — also insert into Instructor table.
                    //    The Instructor table uses the column "Password"
                    //    (not "PasswordHash" — confirmed from source of truth).
                    if (role == "Instructor")
                    {
                        string insertInstQuery =
                            @"INSERT INTO Instructor
                                (InstruEmailAddress, Name, Surname, PhoneNum,
                                 YearsOfExperience, LicenceType,
                                 Specialization, Password)
                              VALUES
                                (@Email, @Name, @Surname, @Phone,
                                 @Experience, @Licence,
                                 @Specialization, @Password)";
                        using (SqlCommand cmdInst = new SqlCommand(insertInstQuery, conn))
                        {
                            cmdInst.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                            cmdInst.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                            cmdInst.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                            cmdInst.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                            cmdInst.Parameters.AddWithValue("@Experience", Convert.ToInt32(txtExperience.Text.Trim()));
                            cmdInst.Parameters.AddWithValue("@Licence", cmbLicence.SelectedItem.ToString());
                            cmdInst.Parameters.AddWithValue("@Specialization", "Manual Driving");
                            cmdInst.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                            cmdInst.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show(
                        "Account created successfully! You can now log in.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    FrontPageForm front = new FrontPageForm();
                    front.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database error during registration:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FocusFirstError()
        {
            Control[] controls = {
                txtEmail, txtName, txtSurname, txtPhone,
                cmbRole, cmbLicence, txtExperience,
                txtPassword, txtConfirmPass
            };

            foreach (Control c in controls)
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(c)) && c.Visible)
                {
                    c.Focus();
                    return;
                }
            }
        }

        // ==========================================
        // NAVIGATION
        // ==========================================
        private void btnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerForm mf = new ManagerForm();
            mf.Show();
            this.Hide();
        }

        private void lblConfirmPass_Click(object sender, EventArgs e) { }
        private void lblPhone_Click(object sender, EventArgs e) { }
        private void lblSurname_Click(object sender, EventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
    }
}