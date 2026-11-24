using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class ManageInstructors : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private bool _isEditing = false;

        public ManageInstructors()
        {
            InitializeComponent();
            SetupGrid();
        }

        // ──────────────────────────────────────────────
        //  Setup DataGridView
        // ──────────────────────────────────────────────
        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InstruEmailAddress",
                HeaderText = "Email",
                Name = "InstruEmailAddress",
                Width = 170
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Name = "Name",
                Width = 100
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Surname",
                HeaderText = "Surname",
                Name = "Surname",
                Width = 100
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PhoneNum",
                HeaderText = "Phone",
                Name = "PhoneNum",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "YearsOfExperience",
                HeaderText = "Exp (Yrs)",
                Name = "YearsOfExperience",
                Width = 65,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "LicenceType",
                HeaderText = "Licence",
                Name = "LicenceType",
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Specialization",
                HeaderText = "Specialization",
                Name = "Specialization",
                Width = 130
            });

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(44, 62, 80);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 250);
            dataGridView1.GridColor = Color.FromArgb(189, 195, 199);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowTemplate.Height = 28;
        }

        // ──────────────────────────────────────────────
        //  Form Load
        // ──────────────────────────────────────────────
        private void ManageInstructors_Load(object sender, EventArgs e)
        {
            LoadInstructors();
            SetAddMode();
        }

        // ──────────────────────────────────────────────
        //  Load Instructors
        // ──────────────────────────────────────────────
        private void LoadInstructors()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "SELECT InstruEmailAddress, Name, Surname, PhoneNum, Address, YearsOfExperience, LicenceType, Specialization " +
                        "FROM Instructor ORDER BY Name, Surname";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                UpdateCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCount()
        {
            lblCount.Text = dataGridView1.Rows.Count + " instructor" + (dataGridView1.Rows.Count == 1 ? "" : "s");
        }

        // ──────────────────────────────────────────────
        //  Mode Switching
        // ──────────────────────────────────────────────
        private void SetAddMode()
        {
            _isEditing = false;
            emailtextBox1.ReadOnly = false;
            emailtextBox1.BackColor = Color.FromArgb(245, 248, 250);
            ClearFields();
            lblMode.Text = "Adding New Instructor";
            lblMode.ForeColor = Color.FromArgb(39, 174, 96);
            btnAdd.Text = "Add Instructor";
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = Color.FromArgb(189, 195, 199);
            emailtextBox1.Focus();
        }

        private void SetEditMode(string email, string name, string surname, string phone, string address, int experience, string licence, string specialization)
        {
            _isEditing = true;
            emailtextBox1.Text = email;
            emailtextBox1.ReadOnly = true;
            emailtextBox1.BackColor = Color.FromArgb(240, 240, 240);
            nametextBox8.Text = name;
            surnametextBox7.Text = surname;
            phonetextBox6.Text = phone;
            AddresstextBox5.Text = address;
            experiencetextBox4.Text = experience.ToString();
            licencetextBox3.Text = licence;
            specialtextBox2.Text = specialization;
            lblMode.Text = "Editing: " + email;
            lblMode.ForeColor = Color.FromArgb(41, 128, 185);
            btnAdd.Text = "Add Instructor";
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnUpdate.Enabled = true;
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            nametextBox8.Focus();
        }

        private void ClearFields()
        {
            emailtextBox1.Clear();
            nametextBox8.Clear();
            surnametextBox7.Clear();
            phonetextBox6.Clear();
            AddresstextBox5.Clear();
            experiencetextBox4.Clear();
            licencetextBox3.SelectedIndex = -1;
            specialtextBox2.SelectedIndex = -1;
        }

        // ──────────────────────────────────────────────
        //  ADD Instructor
        // ──────────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                SetAddMode();
                return;
            }

            if (!ValidateFields()) return;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Instructor WHERE InstruEmailAddress = @Email";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailtextBox1.Text.Trim());
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("An instructor with this email already exists.",
                                "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery =
                        "INSERT INTO Instructor (InstruEmailAddress, Name, Surname, PhoneNum, Address, YearsOfExperience, LicenceType, Specialization) " +
                        "VALUES (@Email, @Name, @Surname, @Phone, @Address, @Experience, @Licence, @Specialization)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailtextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", nametextBox8.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", surnametextBox7.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", phonetextBox6.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", AddresstextBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@Experience", Convert.ToInt32(experiencetextBox4.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Licence", licencetextBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@Specialization", specialtextBox2.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Instructor added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInstructors();
                SetAddMode();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Experience.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding instructor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  UPDATE Instructor
        // ──────────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_isEditing) return;

            if (string.IsNullOrWhiteSpace(nametextBox8.Text) || string.IsNullOrWhiteSpace(surnametextBox7.Text))
            {
                MessageBox.Show("Name and Surname cannot be empty.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "UPDATE Instructor SET Name = @Name, Surname = @Surname, PhoneNum = @Phone, " +
                        "Address = @Address, YearsOfExperience = @Experience, LicenceType = @Licence, Specialization = @Specialization " +
                        "WHERE InstruEmailAddress = @Email";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailtextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", nametextBox8.Text.Trim());
                        cmd.Parameters.AddWithValue("@Surname", surnametextBox7.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", phonetextBox6.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", AddresstextBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@Experience", Convert.ToInt32(experiencetextBox4.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Licence", licencetextBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@Specialization", specialtextBox2.Text.Trim());
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Instructor updated successfully!", "Updated",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                LoadInstructors();
                SetAddMode();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Experience.",
                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating instructor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  DELETE Instructor
        // ──────────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select an instructor to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = dataGridView1.CurrentRow.Cells["InstruEmailAddress"].Value?.ToString();
            if (string.IsNullOrEmpty(email)) return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete instructor: " + email + "?\n\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Instructor WHERE InstruEmailAddress = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Instructor deleted successfully.", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInstructors();
                SetAddMode();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Cannot delete this instructor — they are linked to existing lessons.\nRemove the lesson assignments first.",
                    "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting instructor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  NEW / CLEAR
        // ──────────────────────────────────────────────
        private void btnNew_Click(object sender, EventArgs e)
        {
            SetAddMode();
        }

        // ──────────────────────────────────────────────
        //  Row Click → Edit Mode
        // ──────────────────────────────────────────────
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string email = row.Cells["InstruEmailAddress"].Value?.ToString();
                string name = row.Cells["Name"].Value?.ToString();
                string surname = row.Cells["Surname"].Value?.ToString();
                string phone = row.Cells["PhoneNum"].Value?.ToString();
                int experience = Convert.ToInt32(row.Cells["YearsOfExperience"].Value);
                string licence = row.Cells["LicenceType"].Value?.ToString();
                string specialization = row.Cells["Specialization"].Value?.ToString();

                string address = "";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Address FROM Instructor WHERE InstruEmailAddress = @Email", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        object result = cmd.ExecuteScalar();
                        if (result != null) address = result.ToString();
                    }
                }

                SetEditMode(email, name, surname, phone, address, experience, licence, specialization);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructor: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Search
        // ──────────────────────────────────────────────
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string term = searchTextBox.Text.Trim();

            if (string.IsNullOrEmpty(term))
            {
                LoadInstructors();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "SELECT InstruEmailAddress, Name, Surname, PhoneNum, Address, YearsOfExperience, LicenceType, Specialization " +
                        "FROM Instructor " +
                        "WHERE InstruEmailAddress LIKE @Search OR Name LIKE @Search OR Surname LIKE @Search " +
                        "OR PhoneNum LIKE @Search OR LicenceType LIKE @Search OR Specialization LIKE @Search " +
                        "ORDER BY Name, Surname";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + term + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                UpdateCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching: " + ex.Message,
                    "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  Validation
        // ──────────────────────────────────────────────
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(emailtextBox1.Text))
            {
                MessageBox.Show("Please enter an Email Address.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailtextBox1.Focus();
                return false;
            }

            if (!emailtextBox1.Text.Contains("@") || !emailtextBox1.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailtextBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(nametextBox8.Text))
            {
                MessageBox.Show("Please enter a Name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nametextBox8.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(surnametextBox7.Text))
            {
                MessageBox.Show("Please enter a Surname.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                surnametextBox7.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(licencetextBox3.Text))
            {
                MessageBox.Show("Please select a Licence Type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                licencetextBox3.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(specialtextBox2.Text))
            {
                MessageBox.Show("Please select a Specialization.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                specialtextBox2.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(experiencetextBox4.Text))
            {
                MessageBox.Show("Please enter Years of Experience.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                experiencetextBox4.Focus();
                return false;
            }

            if (!int.TryParse(experiencetextBox4.Text.Trim(), out int exp) || exp < 0)
            {
                MessageBox.Show("Experience must be a valid number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                experiencetextBox4.Focus();
                return false;
            }

            return true;
        }

        // ──────────────────────────────────────────────
        //  Back
        // ──────────────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerForm mf = new ManagerForm();
            mf.Show();
            this.Hide();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    }
}