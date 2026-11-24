
using Driving_School_System_Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class Transactions : Form
    {
        // Replace these placeholders with your existing database credentials.
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private const string SmtpHost = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private static readonly string SenderEmail = Environment.GetEnvironmentVariable("IKHWEZI_SMTP_EMAIL");
        private static readonly string SenderAppPassword = Environment.GetEnvironmentVariable("IKHWEZI_SMTP_APP_PASSWORD");

        private DataTable _currentDetails;
        private int _currentTransactionId;

        public Transactions()
        {
            InitializeComponent();
            ApplyDataGridViewStyles();
            WireExtraEvents();
        }

        // --------------------------------------------------
        // STYLING
        // --------------------------------------------------

        private void ApplyDataGridViewStyles()
        {
            StyleGrid(dataGridView1);
            StyleGrid(dataGridView2);
        }

        private void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;

            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(44, 62, 80),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(4)
            };

            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 248, 250);
            grid.RowTemplate.Height = 28;
            grid.GridColor = Color.FromArgb(189, 195, 199);
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.BorderStyle = BorderStyle.None;

            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
        }

        private void WireExtraEvents()
        {
            // Prevent duplicate event subscriptions.
            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            searchTextBox.KeyDown -= searchTextBox_KeyDown;
            searchTextBox.KeyDown += searchTextBox_KeyDown;
        }

        // --------------------------------------------------
        // FORM LOAD
        // --------------------------------------------------

        private void Transactions_Load(object sender, EventArgs e)
        {
            try
            {
                SetupFilterComboBox();
                BuildTransactionColumns();
                BuildLessonColumns();
                LoadAllTransactions();

                UpdateStatus("Ready — click any transaction row to view details.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error initialising form:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetupFilterComboBox()
        {
            filterComboBox.Items.Clear();

            filterComboBox.Items.AddRange(new object[]
            {
                "All",
                "Paid",
                "Pending",
                "Partial",
                "Overpaid",
                "Cancelled",
                "Refunded"
            });

            filterComboBox.SelectedIndex = 0;
        }

        // --------------------------------------------------
        // TRANSACTION GRID COLUMNS
        // --------------------------------------------------

        private void BuildTransactionColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TransactionID",
                DataPropertyName = "TransactionID",
                HeaderText = "Txn ID",
                Width = 55,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BookingID",
                DataPropertyName = "BookingID",
                HeaderText = "Booking",
                Width = 65,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StudEmailAddress",
                DataPropertyName = "StudEmailAddress",
                HeaderText = "Student Email",
                Width = 175
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PackageID",
                DataPropertyName = "PackageID",
                HeaderText = "Pkg",
                Width = 45,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TransactionDate",
                DataPropertyName = "TransactionDate",
                HeaderText = "Date",
                Width = 115,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy-MM-dd HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Amount",
                DataPropertyName = "Amount",
                HeaderText = "Amount (R)",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ConfirmationType",
                DataPropertyName = "ConfirmationType",
                HeaderText = "Confirmation",
                Width = 95,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });
        }

        // --------------------------------------------------
        // LESSON GRID COLUMNS
        // --------------------------------------------------

        private void BuildLessonColumns()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LessonID",
                DataPropertyName = "LessonID",
                HeaderText = "Lesson",
                Width = 55,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LessonType",
                DataPropertyName = "LessonType",
                HeaderText = "Type",
                Width = 150
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Duration",
                DataPropertyName = "Duration",
                HeaderText = "Mins",
                Width = 50,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LessonDateTime",
                DataPropertyName = "LessonDateTime",
                HeaderText = "Date / Time",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "yyyy-MM-dd HH:mm",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LessonStatus",
                DataPropertyName = "LessonStatus",
                HeaderText = "Status",
                Width = 85,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "InstruEmailAddress",
                DataPropertyName = "InstruEmailAddress",
                HeaderText = "Instructor",
                Width = 170
            });

            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "VehicleType",
                DataPropertyName = "VehicleType",
                HeaderText = "Vehicle",
                Width = 130
            });
        }

        // --------------------------------------------------
        // GET ALL TRANSACTIONS
        // Transactions table remains the main source.
        // Payment is used only to validate the transaction.
        // --------------------------------------------------

        public DataTable GetAllTransactions()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"
                    SELECT
                        t.TransactionID,
                        t.BookingID,
                        t.StudEmailAddress,
                        t.PackageID,
                        t.TransactionDate,
                        t.Amount,
                        t.Status,
                        t.ConfirmationType,
                        t.PaymentID
                    FROM Transactions t
                    INNER JOIN Payment pay
                        ON t.PaymentID = pay.PaymentID
                    WHERE
                        ISNULL(pay.AmountPaid, 0) > 0
                        AND ISNULL(pay.PaymentMethod, '') <> 'Fake'
                    ORDER BY t.TransactionDate DESC;";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // --------------------------------------------------
        // GET TRANSACTION DETAILS
        // LEFT JOIN prevents missing lesson/vehicle records
        // from hiding the entire transaction.
        // --------------------------------------------------

        public DataTable GetTransactionDetails(int txnId)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                string sql = @"
                    SELECT DISTINCT
                        l.LessonID,
                        l.LessonType,
                        l.Duration,
                        l.LessonDateTime,
                        l.Status AS LessonStatus,
                        l.InstruEmailAddress,
                        v.VehicleType,

                        t.TransactionID,
                        t.TransactionDate,
                        t.Status,
                        t.Amount,
                        t.ConfirmationType,

                        t.StudEmailAddress,

                        ISNULL(s.Name, '') + ' ' +
                        ISNULL(s.Surname, '') AS StudentName,

                        ISNULL(s.PhoneNum, '') AS PhoneNum,

                        p.PackageName,
                        p.VehicleCategory,

                        pay.PaymentID,
                        ISNULL(pay.AmountPaid, 0) AS AmountPaid,
                        ISNULL(pay.PaymentMethod, '') AS PaymentMethod,
                        ISNULL(pay.PaymentStatus, '') AS PaymentStatus,
                        pay.PaymentDate

                    FROM Transactions t

                    LEFT JOIN Students s
                        ON t.StudEmailAddress = s.StudEmailAddress

                    LEFT JOIN Booking b
                        ON t.BookingID = b.BookingID

                    LEFT JOIN Packages p
                        ON b.PackageID = p.PackageID

                    INNER JOIN Payment pay
                        ON t.PaymentID = pay.PaymentID

                    LEFT JOIN Lesson l
                        ON l.BookingID = b.BookingID

                    LEFT JOIN LessonVehicle lv
                        ON l.LessonID = lv.LessonID

                    LEFT JOIN Vehicles v
                        ON lv.VehicleID = v.VehicleID

                    WHERE
                        t.TransactionID = @txnId
                        AND ISNULL(pay.AmountPaid, 0) > 0
                        AND ISNULL(pay.PaymentMethod, '') <> 'Fake'

                    ORDER BY l.LessonDateTime;";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@txnId", txnId);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // --------------------------------------------------
        // SEARCH TRANSACTIONS
        // --------------------------------------------------

        public DataTable SearchTransactions(
            string searchTerm,
            string statusFilter)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                StringBuilder sql = new StringBuilder(@"
                    SELECT
                        t.TransactionID,
                        t.BookingID,
                        t.StudEmailAddress,
                        t.PackageID,
                        t.TransactionDate,
                        t.Amount,
                        t.Status,
                        t.ConfirmationType,
                        t.PaymentID
                    FROM Transactions t

                    INNER JOIN Payment pay
                        ON t.PaymentID = pay.PaymentID

                    WHERE
                        ISNULL(pay.AmountPaid, 0) > 0
                        AND ISNULL(pay.PaymentMethod, '') <> 'Fake'");

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    sql.Append(@"
                        AND (
                            CAST(t.TransactionID AS VARCHAR(20))
                                LIKE @search

                            OR CAST(t.BookingID AS VARCHAR(20))
                                LIKE @search

                            OR t.StudEmailAddress
                                LIKE @search

                            OR CAST(t.PackageID AS VARCHAR(20))
                                LIKE @search
                        )");
                }

                if (!string.IsNullOrWhiteSpace(statusFilter)
                    && statusFilter != "All")
                {
                    sql.Append(" AND t.Status = @status");
                }

                sql.Append(" ORDER BY t.TransactionDate DESC;");

                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    cmd.Parameters.AddWithValue(
                        "@search",
                        "%" + searchTerm.Trim() + "%");
                }

                if (!string.IsNullOrWhiteSpace(statusFilter)
                    && statusFilter != "All")
                {
                    cmd.Parameters.AddWithValue("@status", statusFilter);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }

        // --------------------------------------------------
        // LOAD / REFRESH
        // --------------------------------------------------

        private void LoadAllTransactions()
        {
            try
            {
                UseWaitCursor = true;

                dataGridView1.DataSource = GetAllTransactions();

                ApplyStatusColors();

                UpdateStatus(
                    $"Loaded {dataGridView1.Rows.Count} transaction(s).");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading transactions:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void PerformSearch()
        {
            try
            {
                UseWaitCursor = true;

                string term = searchTextBox.Text.Trim();

                string status =
                    filterComboBox.SelectedItem?.ToString() ?? "All";

                DataTable dt = SearchTransactions(term, status);

                dataGridView1.DataSource = dt;

                ApplyStatusColors();

                UpdateStatus(
                    $"Found {dt.Rows.Count} transaction(s)." +
                    (string.IsNullOrWhiteSpace(term)
                        ? ""
                        : $" Search: \"{term}\"") +
                    (status != "All"
                        ? $" Status: {status}"
                        : ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error searching:\n{ex.Message}",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        // --------------------------------------------------
        // SHOW TRANSACTION DETAILS
        // --------------------------------------------------

        private void ShowTransactionDetails(int txnId)
        {
            try
            {
                UseWaitCursor = true;

                _currentTransactionId = txnId;

                DataTable details = GetTransactionDetails(txnId);

                _currentDetails = details;

                if (details.Rows.Count == 0)
                {
                    ClearDetails();

                    MessageBox.Show(
                        "This transaction has no valid payment record. " +
                        "It may have been linked to a deleted or fake payment.",
                        "Transaction Details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                DataRow first = details.Rows[0];

                EmailtextBox1.Text =
                    first["StudEmailAddress"] == DBNull.Value
                        ? ""
                        : first["StudEmailAddress"].ToString();

                namestextBox3.Text =
                    first["StudentName"].ToString().Trim();

                phonetextBox2.Text =
                    first["PhoneNum"].ToString();

                packagetextBox1.Text =
                    first["PackageName"] == DBNull.Value
                        ? ""
                        : first["PackageName"].ToString();

                vehiclegatergorytextBox3.Text =
                    first["VehicleCategory"] == DBNull.Value
                        ? ""
                        : first["VehicleCategory"].ToString();

                paymentIDtextBox6.Text =
                    first["PaymentID"] == DBNull.Value
                        ? ""
                        : first["PaymentID"].ToString();

                decimal amount = 0;

                if (first["AmountPaid"] != DBNull.Value)
                {
                    amount = Convert.ToDecimal(first["AmountPaid"]);
                }

                amounttextBox5.Text = amount.ToString("C2");

                methodtextBox4.Text =
                    first["PaymentMethod"].ToString();

                dataGridView2.DataSource = details;

                ApplyLessonStatusColors();

                int lessonCount = 0;

                foreach (DataRow row in details.Rows)
                {
                    if (row["LessonID"] != DBNull.Value)
                    {
                        lessonCount++;
                    }
                }

                UpdateStatus(
                    $"Viewing Transaction #{txnId} — " +
                    $"{lessonCount} lesson(s).");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error loading details:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        // --------------------------------------------------
        // STATUS COLOURING
        // --------------------------------------------------

        private static void ApplyStatusColor(
            DataGridViewCell cell,
            string status)
        {
            switch (status.Trim().ToLower())
            {
                case "completed":
                case "paid":
                    cell.Style.BackColor =
                        Color.FromArgb(46, 204, 113);
                    cell.Style.ForeColor = Color.White;
                    break;

                case "pending":
                case "partial":
                    cell.Style.BackColor =
                        Color.FromArgb(241, 196, 15);
                    cell.Style.ForeColor = Color.Black;
                    break;

                case "overpaid":
                    cell.Style.BackColor =
                        Color.FromArgb(52, 152, 219);
                    cell.Style.ForeColor = Color.White;
                    break;

                case "cancelled":
                    cell.Style.BackColor =
                        Color.FromArgb(231, 76, 60);
                    cell.Style.ForeColor = Color.White;
                    break;

                case "rescheduled":
                    cell.Style.BackColor =
                        Color.FromArgb(52, 152, 219);
                    cell.Style.ForeColor = Color.White;
                    break;

                case "refunded":
                    cell.Style.BackColor =
                        Color.FromArgb(155, 89, 182);
                    cell.Style.ForeColor = Color.White;
                    break;
            }
        }

        private void ApplyStatusColors()
        {
            int colIndex = -1;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.DataPropertyName == "Status"
                    || col.Name == "Status")
                {
                    colIndex = col.Index;
                    break;
                }
            }

            if (colIndex == -1)
                return;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[colIndex];

                if (cell.Value == null
                    || cell.Value == DBNull.Value)
                {
                    continue;
                }

                ApplyStatusColor(cell, cell.Value.ToString());
            }
        }

        private void ApplyLessonStatusColors()
        {
            int colIndex = -1;

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.DataPropertyName == "LessonStatus"
                    || col.Name == "LessonStatus")
                {
                    colIndex = col.Index;
                    break;
                }
            }

            if (colIndex == -1)
                return;

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCell cell = row.Cells[colIndex];

                if (cell.Value == null
                    || cell.Value == DBNull.Value)
                {
                    continue;
                }

                ApplyStatusColor(cell, cell.Value.ToString());
            }
        }

        // --------------------------------------------------
        // GRID SELECTION
        // --------------------------------------------------

        private void dataGridView1_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int txnId = Convert.ToInt32(
                dataGridView1.Rows[e.RowIndex]
                    .Cells["TransactionID"].Value);

            ShowTransactionDetails(txnId);
        }

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int txnId = Convert.ToInt32(
                dataGridView1.Rows[e.RowIndex]
                    .Cells["TransactionID"].Value);

            ShowTransactionDetails(txnId);
        }

        // --------------------------------------------------
        // SEARCH / FILTER / REFRESH
        // --------------------------------------------------

        private void searchButton_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void searchTextBox_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                PerformSearch();
            }
        }

        private void filterComboBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (filterComboBox.SelectedIndex >= 0)
            {
                PerformSearch();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();

            if (filterComboBox.Items.Count > 0)
            {
                filterComboBox.SelectedIndex = 0;
            }

            LoadAllTransactions();
        }

        // --------------------------------------------------
        // RESET DETAILS
        // --------------------------------------------------

        private void resetButton_Click(object sender, EventArgs e)
        {
            ClearDetails();
            UpdateStatus("Details cleared.");
        }

        private void ClearDetails()
        {
            EmailtextBox1.Clear();
            namestextBox3.Clear();
            phonetextBox2.Clear();
            packagetextBox1.Clear();
            vehiclegatergorytextBox3.Clear();
            paymentIDtextBox6.Clear();
            amounttextBox5.Clear();
            methodtextBox4.Clear();

            dataGridView2.DataSource = null;

            _currentDetails = null;
            _currentTransactionId = 0;
        }

        // --------------------------------------------------
        // NAVIGATION
        // --------------------------------------------------

        private void backbutton_Click(object sender, EventArgs e)
        {
            ReceptionistForm form = new ReceptionistForm();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
            Hide();
        }

        // --------------------------------------------------
        // STATUS BAR
        // --------------------------------------------------

        private void UpdateStatus(string message)
        {
            statusLabel.Text = message;
        }

        // --------------------------------------------------
        // PRINT RECEIPT
        // --------------------------------------------------

        private void printbutton1_Click(object sender, EventArgs e)
        {
            if (_currentDetails == null
                || _currentDetails.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a transaction first.",
                    "No Transaction",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintReceiptPage;

            using (PrintPreviewDialog preview =
                   new PrintPreviewDialog())
            {
                preview.Document = pd;
                preview.Width = 800;
                preview.Height = 600;

                preview.Text =
                    "Receipt Preview — Transaction #" +
                    _currentTransactionId;

                preview.ShowDialog(this);
            }
        }

        private void PrintReceiptPage(
            object sender,
            PrintPageEventArgs e)
        {
            float leftMargin = 40;
            float y = 30;

            Font titleFont =
                new Font("Segoe UI", 16F, FontStyle.Bold);

            Font headerFont =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            Font bodyFont =
                new Font("Segoe UI", 10F);

            Font smallFont =
                new Font("Segoe UI", 9F, FontStyle.Italic);

            Pen linePen =
                new Pen(Color.FromArgb(44, 62, 80), 1.5f);

            using (SolidBrush darkBlueBrush =
                   new SolidBrush(Color.FromArgb(44, 62, 80)))
            using (SolidBrush lightBlueBrush =
                   new SolidBrush(Color.FromArgb(41, 128, 185)))
            using (SolidBrush greyBrush =
                   new SolidBrush(Color.FromArgb(100, 100, 100)))
            {
                e.Graphics.DrawString(
                    "IKHWEZI DRIVING SCHOOL",
                    titleFont,
                    darkBlueBrush,
                    leftMargin,
                    y);

                y += 28;

                e.Graphics.DrawLine(
                    linePen,
                    leftMargin,
                    y,
                    e.PageBounds.Width - 40,
                    y);

                y += 10;

                e.Graphics.DrawString(
                    "TRANSACTION RECEIPT",
                    headerFont,
                    lightBlueBrush,
                    leftMargin,
                    y);

                y += 22;

                if (_currentDetails == null
                    || _currentDetails.Rows.Count == 0)
                {
                    return;
                }

                DataRow first = _currentDetails.Rows[0];

                e.Graphics.DrawString(
                    $"Transaction ID : {_currentTransactionId}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Date           : {SafeDate(first["TransactionDate"])}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Status         : {first["Status"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Confirmation   : {first["ConfirmationType"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin,
                    y);
                y += 24;

                e.Graphics.DrawLine(
                    linePen,
                    leftMargin,
                    y,
                    e.PageBounds.Width - 40,
                    y);
                y += 10;

                e.Graphics.DrawString(
                    "STUDENT",
                    headerFont,
                    darkBlueBrush,
                    leftMargin,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Name  : {first["StudentName"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Email : {first["StudEmailAddress"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Phone : {first["PhoneNum"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 24;

                e.Graphics.DrawString(
                    "PACKAGE",
                    headerFont,
                    darkBlueBrush,
                    leftMargin,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Package  : {first["PackageName"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Category : {first["VehicleCategory"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 24;

                e.Graphics.DrawString(
                    "PAYMENT",
                    headerFont,
                    darkBlueBrush,
                    leftMargin,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Payment ID : {first["PaymentID"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Amount     : {SafeDecimal(first["AmountPaid"]):C2}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Method     : {first["PaymentMethod"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 18;

                e.Graphics.DrawString(
                    $"Pay Status : {first["PaymentStatus"]}",
                    bodyFont,
                    Brushes.Black,
                    leftMargin + 10,
                    y);
                y += 24;

                e.Graphics.DrawLine(
                    linePen,
                    leftMargin,
                    y,
                    e.PageBounds.Width - 40,
                    y);
                y += 10;

                e.Graphics.DrawString(
                    "LESSONS",
                    headerFont,
                    darkBlueBrush,
                    leftMargin,
                    y);
                y += 20;

                string colFormat =
                    "{0,-6} {1,-22} {2,5}  {3,-18} {4,-12} {5}";

                e.Graphics.DrawString(
                    string.Format(
                        colFormat,
                        "ID",
                        "Type",
                        "Mins",
                        "Date/Time",
                        "Status",
                        "Instructor"),
                    headerFont,
                    greyBrush,
                    leftMargin + 10,
                    y);

                y += 16;

                foreach (DataRow lesson in _currentDetails.Rows)
                {
                    if (lesson["LessonID"] == DBNull.Value)
                    {
                        continue;
                    }

                    string lessonDate =
                        lesson["LessonDateTime"] == DBNull.Value
                            ? ""
                            : Convert.ToDateTime(
                                lesson["LessonDateTime"])
                                .ToString("yyyy-MM-dd HH:mm");

                    string line = string.Format(
                        colFormat,
                        lesson["LessonID"],
                        Truncate(
                            lesson["LessonType"].ToString(),
                            20),
                        lesson["Duration"],
                        lessonDate,
                        lesson["LessonStatus"],
                        Truncate(
                            lesson["InstruEmailAddress"].ToString(),
                            25));

                    e.Graphics.DrawString(
                        line,
                        bodyFont,
                        Brushes.Black,
                        leftMargin + 10,
                        y);

                    y += 16;
                }

                y += 20;

                e.Graphics.DrawLine(
                    linePen,
                    leftMargin,
                    y,
                    e.PageBounds.Width - 40,
                    y);

                y += 14;

                e.Graphics.DrawString(
                    "Thank you for choosing Ikhwezi Driving School!",
                    smallFont,
                    darkBlueBrush,
                    leftMargin,
                    y);

                y += 16;

                e.Graphics.DrawString(
                    "We appreciate your trust in us. Drive safely!",
                    smallFont,
                    Brushes.Gray,
                    leftMargin,
                    y);
            }
        }

        private static string SafeDate(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return "N/A";
            }

            return Convert.ToDateTime(value)
                .ToString("yyyy-MM-dd HH:mm");
        }

        private static decimal SafeDecimal(object value)
        {
            if (value == null || value == DBNull.Value)
            {
                return 0;
            }

            return Convert.ToDecimal(value);
        }

        private static string Truncate(string value, int maxLen)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            return value.Length <= maxLen
                ? value
                : value.Substring(0, maxLen - 2) + "..";
        }

        // --------------------------------------------------
        // EMAIL RECEIPT
        // --------------------------------------------------

        private void emailbutton3_Click(object sender, EventArgs e)
        {
            if (_currentDetails == null
                || _currentDetails.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a transaction first.",
                    "No Transaction",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataRow first = _currentDetails.Rows[0];

            string recipientEmail =
                first["StudEmailAddress"].ToString();

            if (string.IsNullOrWhiteSpace(recipientEmail))
            {
                MessageBox.Show(
                    "This transaction does not have a student email address.",
                    "Missing Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = MessageBox.Show(
                $"Send receipt to {recipientEmail}?",
                "Confirm Email",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                UseWaitCursor = true;

                string body = BuildReceiptBody();

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(
                        SenderEmail,
                        "Ikhwezi Driving School");

                    mail.To.Add(recipientEmail);

                    mail.Subject =
                        $"Transaction Receipt — #{_currentTransactionId}";

                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    using (SmtpClient client =
                           new SmtpClient(SmtpHost, SmtpPort))
                    {
                        client.Credentials =
                            new NetworkCredential(
                                SenderEmail,
                                SenderAppPassword);

                        client.EnableSsl = true;
                        client.Send(mail);
                    }
                }

                MessageBox.Show(
                    "Receipt emailed successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateStatus($"Receipt sent to {recipientEmail}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Could not send email:\n{ex.Message}\n\n" +
                    "Check that your Gmail App Password is correct.",
                    "Email Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private string BuildReceiptBody()
        {
            DataRow first = _currentDetails.Rows[0];

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("==========================================");
            sb.AppendLine("       IKHWEZI DRIVING SCHOOL");
            sb.AppendLine("       TRANSACTION RECEIPT");
            sb.AppendLine("==========================================");
            sb.AppendLine();

            sb.AppendLine("TRANSACTION");
            sb.AppendLine(
                $"  Transaction ID : {_currentTransactionId}");

            sb.AppendLine(
                $"  Date           : {SafeDate(first["TransactionDate"])}");

            sb.AppendLine(
                $"  Status         : {first["Status"]}");

            sb.AppendLine(
                $"  Confirmation   : {first["ConfirmationType"]}");

            sb.AppendLine();

            sb.AppendLine("STUDENT");
            sb.AppendLine($"  Name  : {first["StudentName"]}");
            sb.AppendLine($"  Email : {first["StudEmailAddress"]}");
            sb.AppendLine($"  Phone : {first["PhoneNum"]}");
            sb.AppendLine();

            sb.AppendLine("PACKAGE");
            sb.AppendLine($"  Package  : {first["PackageName"]}");
            sb.AppendLine($"  Category : {first["VehicleCategory"]}");
            sb.AppendLine();

            sb.AppendLine("PAYMENT");
            sb.AppendLine($"  Payment ID : {first["PaymentID"]}");

            sb.AppendLine(
                $"  Amount     : {SafeDecimal(first["AmountPaid"]):C2}");

            sb.AppendLine(
                $"  Method     : {first["PaymentMethod"]}");

            sb.AppendLine(
                $"  Status     : {first["PaymentStatus"]}");

            sb.AppendLine();

            sb.AppendLine("------------------------------------------");
            sb.AppendLine("LESSONS");

            foreach (DataRow lesson in _currentDetails.Rows)
            {
                if (lesson["LessonID"] == DBNull.Value)
                {
                    continue;
                }

                string lessonDate =
                    lesson["LessonDateTime"] == DBNull.Value
                        ? "N/A"
                        : Convert.ToDateTime(
                            lesson["LessonDateTime"])
                            .ToString("yyyy-MM-dd HH:mm");

                sb.AppendLine(
                    $"  #{lesson["LessonID"]}  " +
                    $"{lesson["LessonType"],-22}  " +
                    $"{lesson["Duration"],4} mins  " +
                    $"{lessonDate}  " +
                    $"[{lesson["LessonStatus"]}]  " +
                    $"{lesson["InstruEmailAddress"]}");
            }

            sb.AppendLine();
            sb.AppendLine("==========================================");
            sb.AppendLine(
                "Thank you for choosing Ikhwezi Driving School!");
            sb.AppendLine(
                "We appreciate your trust in us. Drive safely!");
            sb.AppendLine("==========================================");

            return sb.ToString();
        }
    }
}
