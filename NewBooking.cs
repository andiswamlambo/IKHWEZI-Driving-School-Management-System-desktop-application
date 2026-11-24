using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class NewBooking : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        public NewBooking()
        {
            InitializeComponent();
            WireValidationEvents();
        }

        // ──────────────────────────────────────────────
        //  Wire Real-Time Validation Events
        // ──────────────────────────────────────────────
        private void WireValidationEvents()
        {
            txtName.TextChanged += txtName_TextChanged;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.KeyPress += txtPhone_KeyPress;
            cmbPackage.SelectedIndexChanged += cmbPackage_SelectedIndexChanged;
            txtEmail.Leave += txtEmail_Leave;
        }

        // ──────────────────────────────────────────────
        //  Form Load
        // ──────────────────────────────────────────────
        private void NewBooking_Load(object sender, EventArgs e)
        {
            LoadPackages();
            ClearErrors();
        }

        // ──────────────────────────────────────────────
        //  Load Packages from Database
        // ──────────────────────────────────────────────
        private void LoadPackages()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT PackageID, PackageName FROM Packages ORDER BY PackageName";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPackage.DisplayMember = "PackageName";
                    cmbPackage.ValueMember = "PackageID";
                    cmbPackage.DataSource = dt;
                    cmbPackage.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading packages: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Auto-Fill Student Details When Email Loses Focus
        // ──────────────────────────────────────────────
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) return;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "SELECT Name, Surname, PhoneNum FROM Students WHERE StudEmailAddress = @Email";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtName.Text = reader["Name"].ToString();
                            txtSurname.Text = reader["Surname"].ToString();
                            txtPhone.Text = reader["PhoneNum"].ToString();

                            lblStudentFound.Text = "Student found!";
                            lblStudentFound.ForeColor = Color.FromArgb(39, 174, 96);
                            lblStudentFound.Visible = true;
                        }
                        else
                        {
                            txtName.Text = "";
                            txtSurname.Text = "";
                            txtPhone.Text = "";

                            lblStudentFound.Text = "New student";
                            lblStudentFound.ForeColor = Color.FromArgb(52, 152, 219);
                            lblStudentFound.Visible = true;

                            MessageBox.Show("Student not found in the system. You will need to enter their details for a new registration.",
                                "New Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking student: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Real-Time Validation: Name
        // ──────────────────────────────────────────────
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                SetError(lblNameError, "");
                return;
            }

            if (!txtName.Text.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
            {
                SetError(lblNameError, "Letters only");
            }
            else if (txtName.Text.Trim().Length < 2)
            {
                SetError(lblNameError, "Too short");
            }
            else
            {
                SetSuccess(lblNameError, "OK");
            }
        }

        // ──────────────────────────────────────────────
        //  Real-Time Validation: Email
        // ──────────────────────────────────────────────
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                SetError(lblEmailError, "");
                return;
            }

            if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                SetSuccess(lblEmailError, "OK");
            }
            else
            {
                SetError(lblEmailError, "Invalid email");
            }
        }

        // ──────────────────────────────────────────────
        //  Real-Time Validation: Phone
        // ──────────────────────────────────────────────
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            string digits = new string(txtPhone.Text.Where(char.IsDigit).ToArray());

            if (digits.Length > 10)
            {
                digits = digits.Substring(0, 10);
            }

            if (digits.Length > 0 && digits[0] != '0')
            {
                digits = "0" + digits;
            }

            if (txtPhone.Text != digits)
            {
                int cursorPos = txtPhone.SelectionStart;
                txtPhone.Text = digits;
                txtPhone.SelectionStart = Math.Min(cursorPos, txtPhone.Text.Length);
            }

            if (digits.Length == 0)
            {
                SetError(lblPhoneError, "");
            }
            else if (digits.Length < 10)
            {
                SetError(lblPhoneError, (10 - digits.Length) + " digit(s) left");
            }
            else if (digits.Length == 10 && digits.StartsWith("0"))
            {
                SetSuccess(lblPhoneError, "OK");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ──────────────────────────────────────────────
        //  Real-Time Validation: Package
        // ──────────────────────────────────────────────
        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPackage.SelectedIndex >= 0)
            {
                SetSuccess(lblPackageError, "OK");
            }
        }

        // ──────────────────────────────────────────────
        //  Validation Helper Methods
        // ──────────────────────────────────────────────
        private void SetError(Label errorLabel, string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                errorLabel.Visible = false;
                return;
            }
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.FromArgb(231, 76, 60);
            errorLabel.Visible = true;
        }

        private void SetSuccess(Label errorLabel, string message)
        {
            errorLabel.Text = message;
            errorLabel.ForeColor = Color.FromArgb(39, 174, 96);
            errorLabel.Visible = true;
        }

        private void ClearErrors()
        {
            lblNameError.Visible = false;
            lblEmailError.Visible = false;
            lblPhoneError.Visible = false;
            lblPackageError.Visible = false;
            lblStudentFound.Visible = false;
        }

        // ──────────────────────────────────────────────
        //  Full Validation on Continue
        // ──────────────────────────────────────────────
        private bool ValidateAll()
        {
            bool valid = true;

            // Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                SetError(lblNameError, "Required");
                valid = false;
            }
            else if (!txtName.Text.All(c => char.IsLetter(c) || c == ' ' || c == '-'))
            {
                SetError(lblNameError, "Letters only");
                valid = false;
            }
            else if (txtName.Text.Trim().Length < 2)
            {
                SetError(lblNameError, "Too short");
                valid = false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                SetError(lblEmailError, "Required");
                valid = false;
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                SetError(lblEmailError, "Invalid email");
                valid = false;
            }

            // Phone
            string phone = new string(txtPhone.Text.Where(char.IsDigit).ToArray());
            if (string.IsNullOrWhiteSpace(phone))
            {
                SetError(lblPhoneError, "Required");
                valid = false;
            }
            else if (phone.Length != 10)
            {
                SetError(lblPhoneError, "Must be 10 digits");
                valid = false;
            }
            else if (!phone.StartsWith("0"))
            {
                SetError(lblPhoneError, "Must start with 0");
                valid = false;
            }

            // Package
            if (cmbPackage.SelectedIndex == -1)
            {
                SetError(lblPackageError, "Required");
                valid = false;
            }

            return valid;
        }

        // ──────────────────────────────────────────────
        //  CONTINUE BUTTON
        // ──────────────────────────────────────────────
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                MessageBox.Show("Please fix the errors highlighted in red before continuing.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StudentData.Name = txtName.Text.Trim();
            StudentData.Surname = txtSurname.Text.Trim();
            StudentData.Email = txtEmail.Text.Trim();
            StudentData.Phone = txtPhone.Text.Trim();
            StudentData.PackageID = Convert.ToInt32(cmbPackage.SelectedValue);
            StudentData.PackageName = cmbPackage.GetItemText(cmbPackage.SelectedItem);

            Schedule scheduleForm = new Schedule();
            scheduleForm.Show();
            this.Hide();
        }

        // ──────────────────────────────────────────────
        //  BACK BUTTON
        // ──────────────────────────────────────────────
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            MakeBooking makeBooking = new MakeBooking();
            makeBooking.Show();
            this.Hide();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}