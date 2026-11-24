using System;
using System.Windows.Forms;

namespace Driving_School_System_Forms
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSignUp = new Driving_school_login_form.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.btnManageVehicles = new System.Windows.Forms.Button();
            this.btnManageInstructors = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvDashboard = new System.Windows.Forms.DataGridView();
            this.lblRecentActivity = new System.Windows.Forms.Label();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Value = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblCard4Value = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).BeginInit();
            this.tlpCards.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.btnSignUp);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnGenerateReports);
            this.pnlSidebar.Controls.Add(this.btnManageVehicles);
            this.pnlSidebar.Controls.Add(this.btnManageInstructors);
            this.pnlSidebar.Controls.Add(this.btnManageStudents);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(214, 459);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnSignUp.BorderRadius = 15;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(17, 362);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(169, 37);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "New Staff Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 80);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(41, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driving School";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ikhwezi";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(17, 417);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 31);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "↔  LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReports.FlatAppearance.BorderSize = 0;
            this.btnGenerateReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReports.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnGenerateReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnGenerateReports.Location = new System.Drawing.Point(0, 192);
            this.btnGenerateReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnGenerateReports.Size = new System.Drawing.Size(214, 34);
            this.btnGenerateReports.TabIndex = 7;
            this.btnGenerateReports.Text = "📊  Generate Reports";
            this.btnGenerateReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReports.UseVisualStyleBackColor = true;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // btnManageVehicles
            // 
            this.btnManageVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageVehicles.FlatAppearance.BorderSize = 0;
            this.btnManageVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageVehicles.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnManageVehicles.Location = new System.Drawing.Point(0, 157);
            this.btnManageVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageVehicles.Name = "btnManageVehicles";
            this.btnManageVehicles.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnManageVehicles.Size = new System.Drawing.Size(214, 34);
            this.btnManageVehicles.TabIndex = 3;
            this.btnManageVehicles.Text = "🚗  Manage Vehicles";
            this.btnManageVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageVehicles.UseVisualStyleBackColor = true;
            this.btnManageVehicles.Click += new System.EventHandler(this.btnManageVehicles_Click);
            // 
            // btnManageInstructors
            // 
            this.btnManageInstructors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageInstructors.FlatAppearance.BorderSize = 0;
            this.btnManageInstructors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInstructors.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageInstructors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnManageInstructors.Location = new System.Drawing.Point(0, 122);
            this.btnManageInstructors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageInstructors.Name = "btnManageInstructors";
            this.btnManageInstructors.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnManageInstructors.Size = new System.Drawing.Size(214, 34);
            this.btnManageInstructors.TabIndex = 2;
            this.btnManageInstructors.Text = "👨‍🏫  Manage Instructors";
            this.btnManageInstructors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageInstructors.UseVisualStyleBackColor = true;
            this.btnManageInstructors.Click += new System.EventHandler(this.btnManageInstructors_Click_1);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnManageStudents.FlatAppearance.BorderSize = 0;
            this.btnManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudents.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnManageStudents.ForeColor = System.Drawing.Color.White;
            this.btnManageStudents.Location = new System.Drawing.Point(0, 88);
            this.btnManageStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnManageStudents.Size = new System.Drawing.Size(214, 34);
            this.btnManageStudents.TabIndex = 1;
            this.btnManageStudents.Text = "🎓  Manage Students";
            this.btnManageStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudents.UseVisualStyleBackColor = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click_1);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnlTopBar.Controls.Add(this.linkLabel1);
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Controls.Add(this.lblWelcome);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(214, 0);
            this.pnlTopBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(643, 61);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(596, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(26, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(291, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(202, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Manager";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlMainContent.Controls.Add(this.pnlDataGrid);
            this.pnlMainContent.Controls.Add(this.tlpCards);
            this.pnlMainContent.Controls.Add(this.label3);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(214, 61);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(643, 398);
            this.pnlMainContent.TabIndex = 2;
            this.pnlMainContent.VisibleChanged += new System.EventHandler(this.ManagerForm_Load);
            this.pnlMainContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainContent_Paint);
            this.pnlMainContent.Resize += new System.EventHandler(this.pnlMainContent_Resize);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvDashboard);
            this.pnlDataGrid.Controls.Add(this.lblRecentActivity);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 154);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(643, 244);
            this.pnlDataGrid.TabIndex = 4;
            // 
            // dgvDashboard
            // 
            this.dgvDashboard.AllowUserToAddRows = false;
            this.dgvDashboard.AllowUserToDeleteRows = false;
            this.dgvDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDashboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDashboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDashboard.ColumnHeadersHeight = 35;
            this.dgvDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDashboard.EnableHeadersVisualStyles = false;
            this.dgvDashboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDashboard.Location = new System.Drawing.Point(9, 31);
            this.dgvDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDashboard.Name = "dgvDashboard";
            this.dgvDashboard.ReadOnly = true;
            this.dgvDashboard.RowHeadersVisible = false;
            this.dgvDashboard.RowHeadersWidth = 51;
            this.dgvDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDashboard.Size = new System.Drawing.Size(625, 206);
            this.dgvDashboard.TabIndex = 1;
            this.dgvDashboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDashboard_CellContentClick);
            // 
            // lblRecentActivity
            // 
            this.lblRecentActivity.AutoSize = true;
            this.lblRecentActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblRecentActivity.Location = new System.Drawing.Point(9, 8);
            this.lblRecentActivity.Name = "lblRecentActivity";
            this.lblRecentActivity.Size = new System.Drawing.Size(133, 21);
            this.lblRecentActivity.TabIndex = 0;
            this.lblRecentActivity.Text = "Recent Bookings";
            // 
            // tlpCards
            // 
            this.tlpCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.pnlCard1, 0, 0);
            this.tlpCards.Controls.Add(this.pnlCard2, 1, 0);
            this.tlpCards.Controls.Add(this.pnlCard3, 2, 0);
            this.tlpCards.Controls.Add(this.pnlCard4, 3, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Location = new System.Drawing.Point(0, 21);
            this.tlpCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(643, 133);
            this.tlpCards.TabIndex = 6;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(10, 15);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(140, 103);
            this.pnlCard1.TabIndex = 0;
            this.pnlCard1.Click += new System.EventHandler(this.pnlCard1_Click);
            this.pnlCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard1_Paint);
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.lblCard1Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(97, 30);
            this.lblCard1Value.TabIndex = 1;
            this.lblCard1Value.Text = "students";
            this.lblCard1Value.Click += new System.EventHandler(this.lblCard1Value_Click);
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard1Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard1Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(96, 19);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "Total Students";
            this.lblCard1Title.Click += new System.EventHandler(this.lblCard1Title_Click);
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(170, 15);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(140, 103);
            this.pnlCard2.TabIndex = 1;
            this.pnlCard2.Click += new System.EventHandler(this.pnlCard2_Click);
            this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard2_Paint);
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblCard2Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(118, 30);
            this.lblCard2Value.TabIndex = 1;
            this.lblCard2Value.Text = "instructors";
            this.lblCard2Value.Click += new System.EventHandler(this.lblCard2Value_Click);
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(108, 19);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "Total Instructors";
            this.lblCard2Title.Click += new System.EventHandler(this.lblCard2Title_Click);
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.lblCard3Value);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(330, 15);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(140, 103);
            this.pnlCard3.TabIndex = 2;
            this.pnlCard3.Click += new System.EventHandler(this.pnlCard3_Click);
            this.pnlCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard3_Paint);
            // 
            // lblCard3Value
            // 
            this.lblCard3Value.AutoSize = true;
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.lblCard3Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard3Value.Name = "lblCard3Value";
            this.lblCard3Value.Size = new System.Drawing.Size(83, 30);
            this.lblCard3Value.TabIndex = 1;
            this.lblCard3Value.Text = "lessons";
            this.lblCard3Value.Click += new System.EventHandler(this.lblCard3Value_Click);
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard3Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(98, 19);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "Active Lessons";
            this.lblCard3Title.Click += new System.EventHandler(this.lblCard3Title_Click);
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Controls.Add(this.lblCard4Value);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(490, 15);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(143, 103);
            this.pnlCard4.TabIndex = 3;
            this.pnlCard4.Click += new System.EventHandler(this.pnlCard4_Click);
            this.pnlCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard4_Paint);
            // 
            // lblCard4Value
            // 
            this.lblCard4Value.AutoSize = true;
            this.lblCard4Value.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblCard4Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard4Value.Name = "lblCard4Value";
            this.lblCard4Value.Size = new System.Drawing.Size(92, 30);
            this.lblCard4Value.TabIndex = 1;
            this.lblCard4Value.Text = "Vehicles";
            this.lblCard4Value.Click += new System.EventHandler(this.lblCard4Value_Click);
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard4Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard4Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(90, 19);
            this.lblCard4Title.TabIndex = 0;
            this.lblCard4Title.Text = "Total Vehicles";
            this.lblCard4Title.Click += new System.EventHandler(this.lblCard4Title_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 10, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(229, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "IKHWEZI  Overview -2026";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driving School - Manager Dashboard";
            this.Load += new System.EventHandler(this.ManagerForm_Load_1);
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlMainContent.PerformLayout();
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashboard)).EndInit();
            this.tlpCards.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.Button btnManageVehicles;
        private System.Windows.Forms.Button btnManageInstructors;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Value;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblCard4Value;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.DataGridView dgvDashboard;
        private System.Windows.Forms.Label lblRecentActivity;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Driving_school_login_form.RoundedButton btnSignUp;
    }
}