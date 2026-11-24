using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class ManageVehicle : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private bool _isEditing = false;

        public ManageVehicle()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VehicleID",
                HeaderText = "Number Plate",
                Name = "VehicleID",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VehicleType",
                HeaderText = "Vehicle Type",
                Name = "VehicleType",
                Width = 170
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TransmissionType",
                HeaderText = "Transmission",
                Name = "TransmissionType",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
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

        private void ManageVehicle_Load(object sender, EventArgs e)
        {
            LoadVehicles();
            SetAddMode();
        }

        private void LoadVehicles()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "SELECT VehicleID, VehicleType, TransmissionType FROM Vehicles ORDER BY VehicleID";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                UpdateCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCount()
        {
            lblCount.Text = dataGridView1.Rows.Count + " vehicle" + (dataGridView1.Rows.Count == 1 ? "" : "s");
        }

        private void SetAddMode()
        {
            _isEditing = false;
            vehicleIDtextBox1.ReadOnly = false;
            vehicleIDtextBox1.BackColor = Color.FromArgb(245, 248, 250);
            vehicleIDtextBox1.Clear();
            vehicletextBox1.SelectedIndex = -1;
            transtextBox2.SelectedIndex = -1;
            lblMode.Text = "Adding New Vehicle";
            lblMode.ForeColor = Color.FromArgb(39, 174, 96);
            btnAdd.Text = "Add Vehicle";
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = Color.FromArgb(189, 195, 199);
            vehicleIDtextBox1.Focus();
        }

        private void SetEditMode(string vehicleId, string vehicleType, string transmission)
        {
            _isEditing = true;
            vehicleIDtextBox1.Text = vehicleId;
            vehicleIDtextBox1.ReadOnly = true;
            vehicleIDtextBox1.BackColor = Color.FromArgb(240, 240, 240);
            vehicletextBox1.Text = vehicleType;
            transtextBox2.Text = transmission;
            lblMode.Text = "Editing: " + vehicleId;
            lblMode.ForeColor = Color.FromArgb(41, 128, 185);
            btnAdd.Text = "Add Vehicle";
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnUpdate.Enabled = true;
            btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            vehicletextBox1.Focus();
        }

        // ──────────────────────────────────────────────
        //  ADD Vehicle
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

                    string checkQuery = "SELECT COUNT(*) FROM Vehicles WHERE VehicleID = @VehicleID";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleIDtextBox1.Text.Trim());
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("A vehicle with this number plate already exists.",
                                "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery =
                        "INSERT INTO Vehicles (VehicleID, VehicleType, TransmissionType) " +
                        "VALUES (@VehicleID, @VehicleType, @TransmissionType)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleIDtextBox1.Text.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@VehicleType", vehicletextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransmissionType", transtextBox2.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vehicle added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVehicles();
                SetAddMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  UPDATE Vehicle
        // ──────────────────────────────────────────────
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_isEditing) return;

            if (string.IsNullOrWhiteSpace(vehicletextBox1.Text) || string.IsNullOrWhiteSpace(transtextBox2.Text))
            {
                MessageBox.Show("Vehicle Type and Transmission cannot be empty.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "UPDATE Vehicles SET VehicleType = @VehicleType, TransmissionType = @TransmissionType " +
                        "WHERE VehicleID = @VehicleID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleIDtextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@VehicleType", vehicletextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransmissionType", transtextBox2.Text.Trim());
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Vehicle updated successfully!", "Updated",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                LoadVehicles();
                SetAddMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────
        //  DELETE Vehicle
        // ──────────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a vehicle to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vehicleId = dataGridView1.CurrentRow.Cells["VehicleID"].Value?.ToString();
            if (string.IsNullOrEmpty(vehicleId)) return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete vehicle: " + vehicleId + "?\n\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query = "DELETE FROM Vehicles WHERE VehicleID = @VehicleID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@VehicleID", vehicleId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vehicle deleted successfully.", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVehicles();
                SetAddMode();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Cannot delete this vehicle — it is linked to existing lessons.\nRemove the lesson assignments first.",
                    "Constraint Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting vehicle: " + ex.Message,
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
                string vehicleId = row.Cells["VehicleID"].Value?.ToString();
                string vehicleType = row.Cells["VehicleType"].Value?.ToString();
                string transmission = row.Cells["TransmissionType"].Value?.ToString();

                SetEditMode(vehicleId, vehicleType, transmission);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicle: " + ex.Message,
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
                LoadVehicles();
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    string query =
                        "SELECT VehicleID, VehicleType, TransmissionType FROM Vehicles " +
                        "WHERE VehicleID LIKE @Search OR VehicleType LIKE @Search OR TransmissionType LIKE @Search " +
                        "ORDER BY VehicleID";

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
            if (string.IsNullOrWhiteSpace(vehicleIDtextBox1.Text))
            {
                MessageBox.Show("Please enter a Number Plate.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vehicleIDtextBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(vehicletextBox1.Text))
            {
                MessageBox.Show("Please select a Vehicle Type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                vehicletextBox1.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(transtextBox2.Text))
            {
                MessageBox.Show("Please select a Transmission Type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                transtextBox2.Focus();
                return false;
            }

            return true;
        }

        // ──────────────────────────────────────────────
        //  Back
        // ──────────────────────────────────────────────
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

        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
    }
}