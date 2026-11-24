using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class RegisterStudentsForm : Form
    {
        private string connectionString =
            global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private DataTable studentsTable = new DataTable();

        public RegisterStudentsForm()
        {
            InitializeComponent();

            txtName.KeyPress += LettersOnly_KeyPress;
            txtSurname.KeyPress += LettersOnly_KeyPress;
            txtPostal.KeyPress += DigitsOnly_KeyPress;
            StuNotxtbox.KeyPress += DigitsOnly_KeyPress;

            txtEmail.TextChanged += (s, e) => lblEmailError.Visible = false;
            txtName.TextChanged += (s, e) => lblNameError.Visible = false;
            txtSurname.TextChanged += (s, e) => lblSurnameError.Visible = false;
            mtbPhone.TextChanged += (s, e) => lblPhoneError.Visible = false;
            StuNotxtbox.TextChanged += (s, e) => StuNolbl.Visible = false;
        }

        private void RegisterStudentsForm_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today.AddYears(-17);
            dtpDOB.MinDate = DateTime.Today.AddYears(-100);

            LoadStudents();
            ClearInputs();
        }

        // ==========================================
        // LOAD STUDENTS
        // ==========================================
        private void LoadStudents()
        {
            try
            {
                string query =
                    "SELECT StudNumber, StudEmailAddress, Name, Surname, PhoneNum, " +
                    "DateOfBirth, StreetAddress, Suburb, City " +
                    "FROM Students ORDER BY Name";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);

                    studentsTable.Clear();
                    da.Fill(studentsTable);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = studentsTable;

                    FormatGrid();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading students: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // FORMAT GRID
        // ==========================================
        private void FormatGrid()
        {
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;

            if (dataGridView1.Columns["StudNumber"] != null)
                dataGridView1.Columns["StudNumber"].HeaderText = "Student Number";

            if (dataGridView1.Columns["StudEmailAddress"] != null)
                dataGridView1.Columns["StudEmailAddress"].HeaderText = "Email Address";

            if (dataGridView1.Columns["Name"] != null)
                dataGridView1.Columns["Name"].HeaderText = "First Name";

            if (dataGridView1.Columns["Surname"] != null)
                dataGridView1.Columns["Surname"].HeaderText = "Surname";

            if (dataGridView1.Columns["PhoneNum"] != null)
                dataGridView1.Columns["PhoneNum"].HeaderText = "Phone Number";

            if (dataGridView1.Columns["DateOfBirth"] != null)
                dataGridView1.Columns["DateOfBirth"].HeaderText = "Date of Birth";

            if (dataGridView1.Columns["StreetAddress"] != null)
                dataGridView1.Columns["StreetAddress"].HeaderText = "Street";

            if (dataGridView1.Columns["Suburb"] != null)
                dataGridView1.Columns["Suburb"].HeaderText = "Suburb";

            if (dataGridView1.Columns["City"] != null)
                dataGridView1.Columns["City"].HeaderText = "City";
        }

        // ==========================================
        // SEARCH
        // ==========================================
        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            if (studentsTable.Columns.Count == 0)
                return;

            string searchTerm =
                searchtextBox.Text.Trim().Replace("'", "''");

            if (searchTerm.Length > 0)
            {
                string filter = "";

                if (studentsTable.Columns.Contains("StudNumber"))
                    filter += $"Convert(StudNumber, 'System.String') LIKE '%{searchTerm}%' OR ";

                if (studentsTable.Columns.Contains("StudEmailAddress"))
                    filter += $"StudEmailAddress LIKE '%{searchTerm}%' OR ";

                if (studentsTable.Columns.Contains("Name"))
                    filter += $"Name LIKE '%{searchTerm}%' OR ";

                if (studentsTable.Columns.Contains("Surname"))
                    filter += $"Surname LIKE '%{searchTerm}%' OR ";

                if (studentsTable.Columns.Contains("PhoneNum"))
                    filter += $"PhoneNum LIKE '%{searchTerm}%' OR ";

                if (filter.EndsWith(" OR "))
                    filter = filter.Substring(0, filter.Length - 4);

                if (!string.IsNullOrEmpty(filter))
                    studentsTable.DefaultView.RowFilter = filter;
            }
            else
            {
                studentsTable.DefaultView.RowFilter = string.Empty;
            }
        }

        // ==========================================
        // SELECT STUDENT FROM GRID
        // ==========================================
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                StuNotxtbox.Text =
                    row.Cells["StudNumber"].Value?.ToString() ?? "";

                txtEmail.Text =
                    row.Cells["StudEmailAddress"].Value?.ToString() ?? "";

                txtName.Text =
                    row.Cells["Name"].Value?.ToString() ?? "";

                txtSurname.Text =
                    row.Cells["Surname"].Value?.ToString() ?? "";

                string phoneVal =
                    row.Cells["PhoneNum"].Value?.ToString() ?? "";

                mtbPhone.Text = phoneVal.PadLeft(10);

                txtStreet.Text =
                    row.Cells["StreetAddress"].Value?.ToString() ?? "";

                txtSuburb.Text =
                    row.Cells["Suburb"].Value?.ToString() ?? "";

                txtCity.Text =
                    row.Cells["City"].Value?.ToString() ?? "";

                if (row.Cells["DateOfBirth"].Value != null &&
                    row.Cells["DateOfBirth"].Value != DBNull.Value)
                {
                    dtpDOB.Value =
                        Convert.ToDateTime(
                            row.Cells["DateOfBirth"].Value);
                }
                else
                {
                    dtpDOB.Value = dtpDOB.MaxDate;
                }

                // Email is used to identify the selected student.
                txtEmail.ReadOnly = true;
                txtEmail.BackColor = Color.LightGray;

                ClearErrorLabels();
            }
        }

        // ==========================================
        // VALIDATION
        // ==========================================
        private bool ValidateInputs()
        {
            bool isValid = true;

            ClearErrorLabels();

            // Student number validation
            if (string.IsNullOrWhiteSpace(StuNotxtbox.Text))
            {
                StuNolbl.Text = "Student number is required.";
                StuNolbl.Visible = true;
                isValid = false;
            }
            else if (!Regex.IsMatch(
                StuNotxtbox.Text.Trim(), @"^\d+$"))
            {
                StuNolbl.Text =
                    "Student number must contain digits only.";

                StuNolbl.Visible = true;
                isValid = false;
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !Regex.IsMatch(
                    txtEmail.Text,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailError.Text =
                    "Please enter a valid email address.";

                lblEmailError.Visible = true;
                isValid = false;
            }

            // First name validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblNameError.Text = "First name is required.";
                lblNameError.Visible = true;
                isValid = false;
            }
            else if (Regex.IsMatch(txtName.Text, @"\d"))
            {
                lblNameError.Text =
                    "Names cannot contain numbers.";

                lblNameError.Visible = true;
                isValid = false;
            }

            // Surname validation
            if (!string.IsNullOrWhiteSpace(txtSurname.Text) &&
                Regex.IsMatch(txtSurname.Text, @"\d"))
            {
                lblSurnameError.Text =
                    "Surnames cannot contain numbers.";

                lblSurnameError.Visible = true;
                isValid = false;
            }

            // Phone validation
            if (!mtbPhone.MaskCompleted)
            {
                lblPhoneError.Text =
                    "Must be exactly 10 digits.";

                lblPhoneError.Visible = true;
                isValid = false;
            }

            // Age validation
            if (dtpDOB.Value.Date >
                DateTime.Today.AddYears(-17))
            {
                MessageBox.Show(
                    "Student must be at least 17 years old.",
                    "Invalid Date of Birth",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                isValid = false;
            }

            return isValid;
        }

        // ==========================================
        // CLEAR ERROR LABELS
        // ==========================================
        private void ClearErrorLabels()
        {
            lblEmailError.Visible = false;
            lblNameError.Visible = false;
            lblSurnameError.Visible = false;
            lblPhoneError.Visible = false;
            StuNolbl.Visible = false;
        }

        // ==========================================
        // KEYPRESS GUARDS
        // ==========================================
        private void LettersOnly_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DigitsOnly_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ==========================================
        // SAVE STUDENT
        // ==========================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                string street = txtStreet.Text.Trim();
                string suburb = txtSuburb.Text.Trim();
                string city = txtCity.Text.Trim();

                // Postal code is appended to City because
                // the current Students table has no PostalCode column.
                if (!string.IsNullOrWhiteSpace(txtPostal.Text))
                {
                    if (!string.IsNullOrWhiteSpace(city))
                        city += " " + txtPostal.Text.Trim();
                    else
                        city = txtPostal.Text.Trim();
                }

                string query = @"
                    INSERT INTO Students
                    (
                        StudNumber,
                        StudEmailAddress,
                        Name,
                        Surname,
                        PhoneNum,
                        DateOfBirth,
                        StreetAddress,
                        Suburb,
                        City,
                        RegisterDate,
                        Status
                    )
                    VALUES
                    (
                        @StudNumber,
                        @Email,
                        @Name,
                        @Surname,
                        @Phone,
                        @DOB,
                        @Street,
                        @Suburb,
                        @City,
                        GETDATE(),
                        'Active'
                    )";

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@StudNumber",
                        StuNotxtbox.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Name",
                        txtName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Surname",
                        string.IsNullOrWhiteSpace(txtSurname.Text)
                            ? (object)DBNull.Value
                            : txtSurname.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Phone",
                        mtbPhone.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@DOB",
                        dtpDOB.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Street",
                        string.IsNullOrWhiteSpace(street)
                            ? (object)DBNull.Value
                            : street);

                    cmd.Parameters.AddWithValue(
                        "@Suburb",
                        string.IsNullOrWhiteSpace(suburb)
                            ? (object)DBNull.Value
                            : suburb);

                    cmd.Parameters.AddWithValue(
                        "@City",
                        string.IsNullOrWhiteSpace(city)
                            ? (object)DBNull.Value
                            : city);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Student Saved Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadStudents();
                ClearInputs();
            }
            catch (SqlException ex)
                when (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show(
                    "This student number or email address already exists.",
                    "Duplicate Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving student: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // UPDATE STUDENT
        // ==========================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please select a student from the grid to update.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                string street = txtStreet.Text.Trim();
                string suburb = txtSuburb.Text.Trim();
                string city = txtCity.Text.Trim();

                if (!string.IsNullOrWhiteSpace(txtPostal.Text))
                {
                    if (!string.IsNullOrWhiteSpace(city))
                        city += " " + txtPostal.Text.Trim();
                    else
                        city = txtPostal.Text.Trim();
                }

                // StudNumber is not changed during an update
                // because it identifies the existing student.
                string query = @"
                    UPDATE Students
                    SET
                        Name = @Name,
                        Surname = @Surname,
                        PhoneNum = @Phone,
                        DateOfBirth = @DOB,
                        StreetAddress = @Street,
                        Suburb = @Suburb,
                        City = @City
                    WHERE StudEmailAddress = @Email";

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    SqlCommand cmd =
                        new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@Email",
                        txtEmail.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Name",
                        txtName.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Surname",
                        string.IsNullOrWhiteSpace(txtSurname.Text)
                            ? (object)DBNull.Value
                            : txtSurname.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@Phone",
                        mtbPhone.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@DOB",
                        dtpDOB.Value.Date);

                    cmd.Parameters.AddWithValue(
                        "@Street",
                        string.IsNullOrWhiteSpace(street)
                            ? (object)DBNull.Value
                            : street);

                    cmd.Parameters.AddWithValue(
                        "@Suburb",
                        string.IsNullOrWhiteSpace(suburb)
                            ? (object)DBNull.Value
                            : suburb);

                    cmd.Parameters.AddWithValue(
                        "@City",
                        string.IsNullOrWhiteSpace(city)
                            ? (object)DBNull.Value
                            : city);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Student Updated Successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadStudents();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating student: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // DELETE STUDENT
        // ==========================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show(
                    "Please select a student from the grid to delete.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {txtName.Text} {txtSurname.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query =
                        "DELETE FROM Students WHERE StudEmailAddress = @Email";

                    using (SqlConnection conn =
                        new SqlConnection(connectionString))
                    {
                        SqlCommand cmd =
                            new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue(
                            "@Email",
                            txtEmail.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Student Deleted Successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadStudents();
                    ClearInputs();
                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    MessageBox.Show(
                        "Cannot delete this student because they have existing Bookings or Lessons.",
                        "Action Restricted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error deleting student: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // CLEAR INPUTS
        // ==========================================
        private void ClearInputs()
        {
            StuNotxtbox.Clear();

            txtEmail.Clear();
            txtName.Clear();
            txtSurname.Clear();
            mtbPhone.Clear();

            txtStreet.Clear();
            txtSuburb.Clear();
            txtCity.Clear();

            cmbProvince.SelectedIndex = -1;
            txtPostal.Clear();

            dtpDOB.Value = dtpDOB.MaxDate;

            txtEmail.ReadOnly = false;
            txtEmail.BackColor = Color.White;

            ClearErrorLabels();

            txtEmail.Focus();
        }

        // ==========================================
        // CLEAR BUTTON
        // ==========================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // ==========================================
        // BACK BUTTON
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

        // ==========================================
        // EMPTY / DESIGNER EVENT HANDLERS
        // ==========================================
        private void grpStudentDetails_Enter(object sender, EventArgs e)
        {
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
        }

        private void RegisterStudentsForm_Load_1(object sender, EventArgs e)
        {
        }

        private void lblProvince_Click(object sender, EventArgs e)
        {
        }

        private void grpStudentDetails_Enter_1(object sender, EventArgs e)
        {
        }
    }
}