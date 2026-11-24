
using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class VerifyPayments : Form
    {
        private string connectionString =
            global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private DataTable paymentsTable = new DataTable();

        public VerifyPayments()
        {
            InitializeComponent();

            txtAmountPaid.TextChanged += txtAmountPaid_TextChanged;
            txtAmountPaid.KeyPress += txtAmountPaid_KeyPress;
        }

        private void VerifyPayments_Load(object sender, EventArgs e)
        {
            LoadAllPendingPayments();
            ClearVerificationPanel();
        }

        // ==========================================
        // LOAD REGISTERED STUDENTS AND PAYMENTS
        // ==========================================
        private void LoadAllPendingPayments(string searchTerm = "")
        {
            try
            {
                string query = @"
                    SELECT
                        py.PaymentID,
                        b.BookingID,
                        s.Name + ' ' + s.Surname AS StudentName,
                        s.StudEmailAddress,
                        ISNULL(pkg.PackageName, 'No Package') AS PackageName,
                        ISNULL(pkg.Amount, 0) AS PackagePrice,
                        ISNULL(py.AmountPaid, 0) AS AmountPaid,
                        ISNULL(py.PaymentMethod, 'Not Recorded') AS PaymentMethod,
                        CASE
                            WHEN b.BookingID IS NULL THEN 'No Booking'
                            WHEN py.PaymentID IS NULL THEN 'No Payment'
                            ELSE py.PaymentStatus
                        END AS PaymentStatus,
                        py.PaymentDate
                    FROM Students s
                    LEFT JOIN Booking b
                        ON s.StudEmailAddress = b.StudEmailAddress
                    LEFT JOIN Packages pkg
                        ON b.PackageID = pkg.PackageID
                    LEFT JOIN Payment py
                        ON b.BookingID = py.BookingID";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    query += @"
                        WHERE
                            s.Name LIKE @Search
                            OR s.Surname LIKE @Search
                            OR s.StudEmailAddress LIKE @Search";
                }

                query += @"
                    ORDER BY
                        CASE
                            WHEN py.PaymentStatus = 'Pending' THEN 1
                            WHEN py.PaymentStatus = 'Partial' THEN 2
                            WHEN py.PaymentStatus = 'Overpaid' THEN 3
                            WHEN py.PaymentStatus = 'Paid' THEN 4
                            ELSE 5
                        END,
                        s.Name,
                        s.Surname,
                        py.PaymentDate DESC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        cmd.Parameters.AddWithValue(
                            "@Search", "%" + searchTerm + "%");
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        paymentsTable.Clear();
                        da.Fill(paymentsTable);

                        dataGridView1.DataSource = paymentsTable;
                        FormatGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading students and payments: " + ex.Message,
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
            dataGridView1.MultiSelect = false;

            if (dataGridView1.Columns["PaymentID"] != null)
                dataGridView1.Columns["PaymentID"].Visible = false;

            if (dataGridView1.Columns["BookingID"] != null)
                dataGridView1.Columns["BookingID"].Visible = false;

            if (dataGridView1.Columns["StudEmailAddress"] != null)
                dataGridView1.Columns["StudEmailAddress"].HeaderText = "Email";

            if (dataGridView1.Columns["StudentName"] != null)
                dataGridView1.Columns["StudentName"].HeaderText = "Student";

            if (dataGridView1.Columns["PackageName"] != null)
                dataGridView1.Columns["PackageName"].HeaderText = "Package";

            if (dataGridView1.Columns["PackagePrice"] != null)
                dataGridView1.Columns["PackagePrice"].HeaderText = "Package Price (R)";

            if (dataGridView1.Columns["AmountPaid"] != null)
                dataGridView1.Columns["AmountPaid"].HeaderText = "Total Paid (R)";

            if (dataGridView1.Columns["PaymentMethod"] != null)
                dataGridView1.Columns["PaymentMethod"].HeaderText = "Method";

            if (dataGridView1.Columns["PaymentStatus"] != null)
                dataGridView1.Columns["PaymentStatus"].HeaderText = "Status";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string status =
                    row.Cells["PaymentStatus"].Value?.ToString();

                if (status == "Pending")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
                else if (status == "Paid")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
                else if (status == "Partial")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
                else if (status == "Overpaid")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192);
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        // ==========================================
        // GRID CLICK - POPULATE PAYMENT PANEL
        // ==========================================
        private void dataGridView1_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            lblStudentName.Text =
                row.Cells["StudentName"].Value?.ToString() ?? "-";

            lblPackage.Text =
                row.Cells["PackageName"].Value?.ToString() ?? "-";

            decimal packagePrice = 0m;
            decimal currentPaid = 0m;

            if (row.Cells["PackagePrice"].Value != DBNull.Value)
                packagePrice = Convert.ToDecimal(row.Cells["PackagePrice"].Value);

            if (row.Cells["AmountPaid"].Value != DBNull.Value)
                currentPaid = Convert.ToDecimal(row.Cells["AmountPaid"].Value);

            lblTotalPrice.Text = "R " + packagePrice.ToString("N2");

            string method =
                row.Cells["PaymentMethod"].Value?.ToString() ?? "";

            if (cmbMethod.Items.Contains(method) &&
                !string.IsNullOrWhiteSpace(method))
            {
                cmbMethod.SelectedItem = method;
            }
            else if (cmbMethod.Items.Count > 0)
            {
                cmbMethod.SelectedIndex = 0;
            }

            string status =
                row.Cells["PaymentStatus"].Value?.ToString() ?? "";

            bool hasPaymentRecord =
                row.Cells["PaymentID"].Value != DBNull.Value &&
                row.Cells["PaymentID"].Value != null;

            bool hasBooking =
                row.Cells["BookingID"].Value != DBNull.Value &&
                row.Cells["BookingID"].Value != null;

            // Student has no booking
            if (!hasBooking)
            {
                btnVerifyPayment.Enabled = false;
                btnVerifyPayment.Text = "No Booking";

                txtAmountPaid.Text = "0.00";
                txtAmountPaid.ReadOnly = true;

                lblRemainingBalance.Text = "R 0.00";
                lblRefundDue.Text = "R 0.00";

                MessageBox.Show(
                    "This student has not made a booking yet.\n" +
                    "A booking is required before a payment can be recorded.",
                    "Booking Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Student has booking but no payment record
            if (!hasPaymentRecord)
            {
                btnVerifyPayment.Enabled = true;
                btnVerifyPayment.Text = "Record First Payment";

                txtAmountPaid.Text = "0.00";
                txtAmountPaid.ReadOnly = false;

                UpdateCalculatedFields(packagePrice, 0m, 0m);

                return;
            }

            // Existing payment is already settled
            if (status == "Paid")
            {
                btnVerifyPayment.Text = "Already Settled";
                btnVerifyPayment.Enabled = false;

                txtAmountPaid.Text = "0.00";
                txtAmountPaid.ReadOnly = true;

                lblRemainingBalance.Text = "R 0.00";
                lblRefundDue.Text = "R 0.00";
            }
            else if (status == "Overpaid")
            {
                btnVerifyPayment.Text = "Process Refund";
                btnVerifyPayment.Enabled = true;

                txtAmountPaid.Text = "0.00";
                txtAmountPaid.ReadOnly = true;

                decimal refund = currentPaid - packagePrice;

                lblRemainingBalance.Text = "R 0.00";
                lblRefundDue.Text = "R " + refund.ToString("N2");
            }
            else
            {
                btnVerifyPayment.Text = "Add Payment";
                btnVerifyPayment.Enabled = true;

                txtAmountPaid.Text = "0.00";
                txtAmountPaid.ReadOnly = false;

                UpdateCalculatedFields(packagePrice, currentPaid, 0m);
            }
        }

        // ==========================================
        // CALCULATE BALANCE AND REFUND
        // ==========================================
        private void UpdateCalculatedFields(
            decimal packagePrice,
            decimal currentPaid,
            decimal payingNow)
        {
            decimal projectedTotal = currentPaid + payingNow;

            decimal remaining = 0m;
            decimal refund = 0m;

            if (projectedTotal < packagePrice)
                remaining = packagePrice - projectedTotal;
            else if (projectedTotal > packagePrice)
                refund = projectedTotal - packagePrice;

            lblRemainingBalance.Text = "R " + remaining.ToString("N2");
            lblRefundDue.Text = "R " + refund.ToString("N2");
        }

        // ==========================================
        // RECORD / VERIFY PAYMENT
        // ==========================================
        private void btnVerifyPayment_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a student from the grid.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            if (row.Cells["BookingID"].Value == DBNull.Value ||
                row.Cells["BookingID"].Value == null)
            {
                MessageBox.Show(
                    "This student must have a booking before a payment can be recorded.",
                    "Booking Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int bookingID =
                Convert.ToInt32(row.Cells["BookingID"].Value);

            bool hasPaymentRecord =
                row.Cells["PaymentID"].Value != DBNull.Value &&
                row.Cells["PaymentID"].Value != null;

            int paymentID = 0;

            if (hasPaymentRecord)
                paymentID = Convert.ToInt32(row.Cells["PaymentID"].Value);

            decimal packagePrice =
                Convert.ToDecimal(row.Cells["PackagePrice"].Value);

            decimal currentPaid =
                Convert.ToDecimal(row.Cells["AmountPaid"].Value);

            string currentStatus =
                row.Cells["PaymentStatus"].Value?.ToString() ?? "";

            // ==========================================
            // PROCESS REFUND
            // ==========================================
            if (currentStatus == "Overpaid")
            {
                decimal refundAmount = currentPaid - packagePrice;

                DialogResult result = MessageBox.Show(
                    $"Confirm that R {refundAmount:N2} has been refunded " +
                    "to the student.\nThis will settle the account.",
                    "Confirm Refund",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string refundQuery = @"
                            UPDATE Payment
                            SET PaymentStatus = 'Paid',
                                AmountPaid = @AmountPaid,
                                PaymentDate = @Date
                            WHERE PaymentID = @PaymentID";

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(refundQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@AmountPaid", packagePrice);
                            cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            "Refund processed. Account is now fully paid.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LoadAllPendingPayments(txtSearch.Text.Trim());
                        ClearVerificationPanel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Error processing refund: " + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }

                return;
            }

            // ==========================================
            // VALIDATE NEW PAYMENT
            // ==========================================
            if (cmbMethod.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Method Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmountPaid.Text, out decimal amountNow) ||
                amountNow <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid amount greater than 0.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAmountPaid.Focus();
                return;
            }

            // ==========================================
            // INITIAL DEPOSIT RULE
            // ==========================================
            if (currentPaid == 0)
            {
                decimal depositPercentage = 15m;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string depositQuery = @"
                            SELECT TOP 1 DepositPercentage
                            FROM Packages
                            WHERE PackageID =
                                (SELECT PackageID
                                 FROM Booking
                                 WHERE BookingID = @BookingID)";

                        using (SqlCommand cmd =
                            new SqlCommand(depositQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);

                            conn.Open();

                            object value = cmd.ExecuteScalar();

                            if (value != null && value != DBNull.Value)
                                depositPercentage = Convert.ToDecimal(value);
                        }
                    }
                }
                catch
                {
                    // Use default 15% deposit if percentage cannot be retrieved.
                }

                decimal requiredDeposit =
                    packagePrice * (depositPercentage / 100m);

                if (amountNow < requiredDeposit)
                {
                    MessageBox.Show(
                        $"Payment rejected. The minimum initial deposit is " +
                        $"R {requiredDeposit:N2} ({depositPercentage:0}%).",
                        "Deposit Incomplete",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            decimal newTotalPaid = currentPaid + amountNow;
            string newStatus;

            if (newTotalPaid < packagePrice)
            {
                newStatus = "Partial";

                MessageBox.Show(
                    $"Payment recorded. Remaining balance: " +
                    $"R {(packagePrice - newTotalPaid):N2}",
                    "Partial Payment",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (newTotalPaid > packagePrice)
            {
                newStatus = "Overpaid";

                MessageBox.Show(
                    $"Payment recorded. Student overpaid by " +
                    $"R {(newTotalPaid - packagePrice):N2}.\n" +
                    "A refund is required.",
                    "Refund Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                newStatus = "Paid";

                MessageBox.Show(
                    $"Payment of R {amountNow:N2} recorded. Account fully paid!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            // ==========================================
            // SAVE PAYMENT
            // INSERT when first payment; UPDATE otherwise
            // ==========================================
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query;

                    if (!hasPaymentRecord)
                    {
                        // FIRST PAYMENT: create a new Payment row
                        query = @"
                            INSERT INTO Payment
                                (BookingID, PaymentStatus, PaymentMethod,
                                 AmountPaid, PaymentDate)
                            VALUES
                                (@BookingID, @Status, @Method,
                                 @AmountPaid, @Date)";
                    }
                    else
                    {
                        // EXISTING PAYMENT: update the current row
                        query = @"
                            UPDATE Payment
                            SET PaymentStatus = @Status,
                                PaymentMethod = @Method,
                                AmountPaid = @AmountPaid,
                                PaymentDate = @Date
                            WHERE PaymentID = @PaymentID";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!hasPaymentRecord)
                        {
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                        }

                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue(
                            "@Method", cmbMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@AmountPaid", newTotalPaid);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "The payment has been successfully saved to the database.",
                    "Payment Recorded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadAllPendingPayments(txtSearch.Text.Trim());
                ClearVerificationPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error recording payment: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CLEAR PAYMENT PANEL
        // ==========================================
        private void ClearVerificationPanel()
        {
            lblStudentName.Text = "-";
            lblPackage.Text = "-";
            lblTotalPrice.Text = "R 0.00";

            txtAmountPaid.Text = "0.00";
            txtAmountPaid.ReadOnly = false;

            if (cmbMethod.Items.Count > 0)
                cmbMethod.SelectedIndex = 0;

            btnVerifyPayment.Enabled = false;
            btnVerifyPayment.Text = "Confirm Payment";

            lblRemainingBalance.Text = "R 0.00";
            lblRefundDue.Text = "R 0.00";
        }

        // ==========================================
        // SEARCH
        // ==========================================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAllPendingPayments(txtSearch.Text.Trim());
            ClearVerificationPanel();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch_Click(sender, e);
        }

        // ==========================================
        // BACK TO RECEPTIONIST
        // ==========================================
        private void btnBack_Click(object sender, EventArgs e)
        {
            ReceptionistForm recep = new ReceptionistForm();
            recep.Show();
            this.Hide();
        }

        // ==========================================
        // LIVE PAYMENT CALCULATION
        // ==========================================
        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            if (row.Cells["BookingID"].Value == DBNull.Value ||
                row.Cells["BookingID"].Value == null)
                return;

            decimal packagePrice =
                Convert.ToDecimal(row.Cells["PackagePrice"].Value);

            decimal currentPaid =
                Convert.ToDecimal(row.Cells["AmountPaid"].Value);

            string status =
                row.Cells["PaymentStatus"].Value?.ToString() ?? "";

            if (status != "Overpaid" && status != "Paid")
            {
                if (decimal.TryParse(txtAmountPaid.Text, out decimal payingNow))
                    UpdateCalculatedFields(packagePrice, currentPaid, payingNow);
                else
                    UpdateCalculatedFields(packagePrice, currentPaid, 0m);
            }
        }

        private void txtAmountPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;

            if (e.KeyChar == '.' &&
                textBox != null &&
                textBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
