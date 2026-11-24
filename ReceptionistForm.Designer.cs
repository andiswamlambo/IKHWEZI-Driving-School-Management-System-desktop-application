using System;
using System.Windows.Forms;

namespace Driving_School_System_Forms
{
    partial class ReceptionistForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewTransactions = new System.Windows.Forms.Button();
            this.btnLessonHistory = new System.Windows.Forms.Button();
            this.btnViewAssigned = new System.Windows.Forms.Button();
            this.btnViewAvailable = new System.Windows.Forms.Button();
            this.btnBookSession = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvUpcomingSessions = new System.Windows.Forms.DataGridView();
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
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingSessions)).BeginInit();
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
            this.pnlSidebar.Controls.Add(this.button1);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnViewTransactions);
            this.pnlSidebar.Controls.Add(this.btnLessonHistory);
            this.pnlSidebar.Controls.Add(this.btnViewAssigned);
            this.pnlSidebar.Controls.Add(this.btnViewAvailable);
            this.pnlSidebar.Controls.Add(this.btnBookSession);
            this.pnlSidebar.Controls.Add(this.btnRegister);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(214, 459);
            this.pnlSidebar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.button1.Location = new System.Drawing.Point(0, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(214, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "💰  Verify Payment";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 423);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 31);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "↔  LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driving School";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(31, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "IKHWEZI";
            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewTransactions.FlatAppearance.BorderSize = 0;
            this.btnViewTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTransactions.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnViewTransactions.Location = new System.Drawing.Point(0, 260);
            this.btnViewTransactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnViewTransactions.Size = new System.Drawing.Size(214, 34);
            this.btnViewTransactions.TabIndex = 8;
            this.btnViewTransactions.Text = "💰  View Transactions";
            this.btnViewTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTransactions.UseVisualStyleBackColor = true;
            this.btnViewTransactions.Click += new System.EventHandler(this.btnViewTransactions_Click_1);
            // 
            // btnLessonHistory
            // 
            this.btnLessonHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLessonHistory.FlatAppearance.BorderSize = 0;
            this.btnLessonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLessonHistory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLessonHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnLessonHistory.Location = new System.Drawing.Point(0, 226);
            this.btnLessonHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLessonHistory.Name = "btnLessonHistory";
            this.btnLessonHistory.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnLessonHistory.Size = new System.Drawing.Size(214, 34);
            this.btnLessonHistory.TabIndex = 7;
            this.btnLessonHistory.Text = "📜  Lesson History";
            this.btnLessonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLessonHistory.UseVisualStyleBackColor = true;
            this.btnLessonHistory.Click += new System.EventHandler(this.btnLessonHistory_Click_1);
            // 
            // btnViewAssigned
            // 
            this.btnViewAssigned.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAssigned.FlatAppearance.BorderSize = 0;
            this.btnViewAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAssigned.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnViewAssigned.Location = new System.Drawing.Point(0, 191);
            this.btnViewAssigned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAssigned.Name = "btnViewAssigned";
            this.btnViewAssigned.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnViewAssigned.Size = new System.Drawing.Size(214, 34);
            this.btnViewAssigned.TabIndex = 5;
            this.btnViewAssigned.Text = "📋  Assigned Sessions";
            this.btnViewAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAssigned.UseVisualStyleBackColor = true;
            this.btnViewAssigned.Click += new System.EventHandler(this.btnViewAssigned_Click);
            // 
            // btnViewAvailable
            // 
            this.btnViewAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewAvailable.FlatAppearance.BorderSize = 0;
            this.btnViewAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAvailable.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnViewAvailable.Location = new System.Drawing.Point(0, 157);
            this.btnViewAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAvailable.Name = "btnViewAvailable";
            this.btnViewAvailable.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnViewAvailable.Size = new System.Drawing.Size(214, 34);
            this.btnViewAvailable.TabIndex = 4;
            this.btnViewAvailable.Text = "📅  Available Sessions";
            this.btnViewAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAvailable.UseVisualStyleBackColor = true;
            this.btnViewAvailable.Click += new System.EventHandler(this.btnViewAvailable_Click);
            // 
            // btnBookSession
            // 
            this.btnBookSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBookSession.FlatAppearance.BorderSize = 0;
            this.btnBookSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSession.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBookSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnBookSession.Location = new System.Drawing.Point(0, 122);
            this.btnBookSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookSession.Name = "btnBookSession";
            this.btnBookSession.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnBookSession.Size = new System.Drawing.Size(214, 34);
            this.btnBookSession.TabIndex = 3;
            this.btnBookSession.Text = "🚗  Book Driving Session";
            this.btnBookSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSession.UseVisualStyleBackColor = true;
            this.btnBookSession.Click += new System.EventHandler(this.btnBookSession_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(0, 88);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnRegister.Size = new System.Drawing.Size(214, 34);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "📝  Register Student";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click_1);
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
            this.linkLabel1.Location = new System.Drawing.Point(596, 9);
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
            this.lblTitle.Size = new System.Drawing.Size(162, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "2026 Overview";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(321, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(223, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, Receptionist";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlMainContent.Controls.Add(this.pnlDataGrid);
            this.pnlMainContent.Controls.Add(this.tlpCards);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(214, 61);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(643, 398);
            this.pnlMainContent.TabIndex = 2;
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvUpcomingSessions);
            this.pnlDataGrid.Controls.Add(this.lblRecentActivity);
            this.pnlDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataGrid.Location = new System.Drawing.Point(0, 145);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(643, 253);
            this.pnlDataGrid.TabIndex = 4;
            // 
            // dgvUpcomingSessions
            // 
            this.dgvUpcomingSessions.AllowUserToAddRows = false;
            this.dgvUpcomingSessions.AllowUserToDeleteRows = false;
            this.dgvUpcomingSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpcomingSessions.BackgroundColor = System.Drawing.Color.White;
            this.dgvUpcomingSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUpcomingSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUpcomingSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvUpcomingSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUpcomingSessions.ColumnHeadersHeight = 35;
            this.dgvUpcomingSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUpcomingSessions.EnableHeadersVisualStyles = false;
            this.dgvUpcomingSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvUpcomingSessions.Location = new System.Drawing.Point(9, 31);
            this.dgvUpcomingSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUpcomingSessions.Name = "dgvUpcomingSessions";
            this.dgvUpcomingSessions.ReadOnly = true;
            this.dgvUpcomingSessions.RowHeadersVisible = false;
            this.dgvUpcomingSessions.RowHeadersWidth = 51;
            this.dgvUpcomingSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUpcomingSessions.Size = new System.Drawing.Size(625, 215);
            this.dgvUpcomingSessions.TabIndex = 1;
            this.dgvUpcomingSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpcomingSessions_CellContentClick);
            // 
            // lblRecentActivity
            // 
            this.lblRecentActivity.AutoSize = true;
            this.lblRecentActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblRecentActivity.Location = new System.Drawing.Point(9, 8);
            this.lblRecentActivity.Name = "lblRecentActivity";
            this.lblRecentActivity.Size = new System.Drawing.Size(152, 21);
            this.lblRecentActivity.TabIndex = 0;
            this.lblRecentActivity.Text = "Upcoming Sessions";
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
            this.tlpCards.Location = new System.Drawing.Point(0, 0);
            this.tlpCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(643, 145);
            this.tlpCards.TabIndex = 5;
            // 
            // pnlCard1
            // 
            this.pnlCard1.AutoSize = true;
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard1.Location = new System.Drawing.Point(10, 15);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(140, 115);
            this.pnlCard1.TabIndex = 0;
            this.pnlCard1.Click += new System.EventHandler(this.pnlCard1_Click);
            this.pnlCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard1_Paint);
            // 
            // lblCard1Value
            // 
            this.lblCard1Value.AutoSize = true;
            this.lblCard1Value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCard1Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.lblCard1Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard1Value.Name = "lblCard1Value";
            this.lblCard1Value.Size = new System.Drawing.Size(90, 51);
            this.lblCard1Value.TabIndex = 1;
            this.lblCard1Value.Text = "NO.";
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
            this.pnlCard2.AutoSize = true;
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard2.Location = new System.Drawing.Point(170, 15);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(140, 115);
            this.pnlCard2.TabIndex = 1;
            this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard2_Paint);
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblCard2Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(111, 51);
            this.lblCard2Value.TabIndex = 1;
            this.lblCard2Value.Text = "price";
            this.lblCard2Value.Click += new System.EventHandler(this.lblCard2Value_Click);
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(94, 19);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "Total Revenue";
            this.lblCard2Title.Click += new System.EventHandler(this.lblCard2Title_Click);
            // 
            // pnlCard3
            // 
            this.pnlCard3.AutoSize = true;
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.lblCard3Value);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard3.Location = new System.Drawing.Point(330, 15);
            this.pnlCard3.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(140, 115);
            this.pnlCard3.TabIndex = 2;
            this.pnlCard3.Click += new System.EventHandler(this.pnlCard3_Click);
            this.pnlCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard3_Paint);
            // 
            // lblCard3Value
            // 
            this.lblCard3Value.AutoSize = true;
            this.lblCard3Value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCard3Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(211)))));
            this.lblCard3Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard3Value.Name = "lblCard3Value";
            this.lblCard3Value.Size = new System.Drawing.Size(90, 51);
            this.lblCard3Value.TabIndex = 1;
            this.lblCard3Value.Text = "NO.";
            this.lblCard3Value.Click += new System.EventHandler(this.lblCard3Value_Click);
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard3Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard3Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(105, 19);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "Bookings Today";
            this.lblCard3Title.Click += new System.EventHandler(this.lblCard3Title_Click);
            // 
            // pnlCard4
            // 
            this.pnlCard4.AutoSize = true;
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.Controls.Add(this.lblCard4Value);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard4.Location = new System.Drawing.Point(490, 15);
            this.pnlCard4.Margin = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Size = new System.Drawing.Size(143, 115);
            this.pnlCard4.TabIndex = 3;
            this.pnlCard4.Click += new System.EventHandler(this.pnlCard4_Click);
            this.pnlCard4.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard4_Paint);
            // 
            // lblCard4Value
            // 
            this.lblCard4Value.AutoSize = true;
            this.lblCard4Value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCard4Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(67)))));
            this.lblCard4Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard4Value.Name = "lblCard4Value";
            this.lblCard4Value.Size = new System.Drawing.Size(90, 51);
            this.lblCard4Value.TabIndex = 1;
            this.lblCard4Value.Text = "NO.";
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
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReceptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driving School - Receptionist Dashboard";
            this.Load += new System.EventHandler(this.ReceptionistForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingSessions)).EndInit();
            this.tlpCards.ResumeLayout(false);
            this.tlpCards.PerformLayout();
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
        private System.Windows.Forms.Button btnViewTransactions;
        private System.Windows.Forms.Button btnLessonHistory;
        private System.Windows.Forms.Button btnViewAssigned;
        private System.Windows.Forms.Button btnViewAvailable;
        private System.Windows.Forms.Button btnBookSession;
        private System.Windows.Forms.Button btnRegister;
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
        private System.Windows.Forms.DataGridView dgvUpcomingSessions;
        private System.Windows.Forms.Label lblRecentActivity;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnLogout;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}