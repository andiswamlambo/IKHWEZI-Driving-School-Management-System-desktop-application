using System.Windows.Forms;

namespace Driving_School_System_Forms
{
    partial class InstructorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewAssigned = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlDataGrid = new System.Windows.Forms.Panel();
            this.dgvAssignedSessions = new System.Windows.Forms.DataGridView();
            this.lblRecentActivity = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Value = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Value = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSessions)).BeginInit();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnViewAssigned);
            this.pnlSidebar.Controls.Add(this.btnUpdateStatus);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(214, 459);
            this.pnlSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 89);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(41, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Driving School";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 1;
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
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "↔  LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewAssigned
            // 
            this.btnViewAssigned.FlatAppearance.BorderSize = 0;
            this.btnViewAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAssigned.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnViewAssigned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnViewAssigned.Location = new System.Drawing.Point(-6, 157);
            this.btnViewAssigned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewAssigned.Name = "btnViewAssigned";
            this.btnViewAssigned.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnViewAssigned.Size = new System.Drawing.Size(214, 34);
            this.btnViewAssigned.TabIndex = 7;
            this.btnViewAssigned.Text = "📋  View Assigned Sessions";
            this.btnViewAssigned.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAssigned.UseVisualStyleBackColor = true;
            this.btnViewAssigned.Click += new System.EventHandler(this.btnViewAssigned_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.btnUpdateStatus.Location = new System.Drawing.Point(-6, 121);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnUpdateStatus.Size = new System.Drawing.Size(214, 34);
            this.btnUpdateStatus.TabIndex = 6;
            this.btnUpdateStatus.Text = "🔄  Update Lesson Status";
            this.btnUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click_1);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Today\'s Teaching Overview";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(390, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(158, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, User";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(596, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.AutoScroll = true;
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pnlMainContent.Controls.Add(this.pnlDataGrid);
            this.pnlMainContent.Controls.Add(this.pnlCard2);
            this.pnlMainContent.Controls.Add(this.pnlCard1);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(214, 61);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(643, 398);
            this.pnlMainContent.TabIndex = 2;
            this.pnlMainContent.VisibleChanged += new System.EventHandler(this.InstructorForm_Load);
            // 
            // pnlDataGrid
            // 
            this.pnlDataGrid.BackColor = System.Drawing.Color.White;
            this.pnlDataGrid.Controls.Add(this.dgvAssignedSessions);
            this.pnlDataGrid.Controls.Add(this.lblRecentActivity);
            this.pnlDataGrid.Location = new System.Drawing.Point(17, 153);
            this.pnlDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDataGrid.Name = "pnlDataGrid";
            this.pnlDataGrid.Size = new System.Drawing.Size(609, 229);
            this.pnlDataGrid.TabIndex = 4;
            // ADDED: Anchor to make the DataGrid Panel stretch when maximizing
            this.pnlDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // dgvAssignedSessions
            // 
            this.dgvAssignedSessions.AllowUserToAddRows = false;
            this.dgvAssignedSessions.AllowUserToDeleteRows = false;
            this.dgvAssignedSessions.BackgroundColor = System.Drawing.Color.White;
            this.dgvAssignedSessions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignedSessions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAssignedSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.dgvAssignedSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAssignedSessions.ColumnHeadersHeight = 35;
            this.dgvAssignedSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAssignedSessions.EnableHeadersVisualStyles = false;
            this.dgvAssignedSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvAssignedSessions.Location = new System.Drawing.Point(9, 31);
            this.dgvAssignedSessions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAssignedSessions.Name = "dgvAssignedSessions";
            this.dgvAssignedSessions.ReadOnly = true;
            this.dgvAssignedSessions.RowHeadersVisible = false;
            this.dgvAssignedSessions.RowHeadersWidth = 51;
            this.dgvAssignedSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignedSessions.Size = new System.Drawing.Size(591, 191);
            this.dgvAssignedSessions.TabIndex = 1;
            // ADDED: Anchor to make the DataGridView stretch inside its panel when maximizing
            this.dgvAssignedSessions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssignedSessions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssignedSessions_CellContentClick);
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
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.lblCard2Value);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Location = new System.Drawing.Point(349, 15);
            this.pnlCard2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(223, 115);
            this.pnlCard2.TabIndex = 1;
            // ADDED: Anchor right so it maintains gap when resizing width
            this.pnlCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard2.Click += new System.EventHandler(this.pnlCard2_Click);
            this.pnlCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard2_Paint);
            // 
            // lblCard2Value
            // 
            this.lblCard2Value.AutoSize = true;
            this.lblCard2Value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblCard2Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblCard2Value.Location = new System.Drawing.Point(13, 15);
            this.lblCard2Value.Name = "lblCard2Value";
            this.lblCard2Value.Size = new System.Drawing.Size(90, 51);
            this.lblCard2Value.TabIndex = 1;
            this.lblCard2Value.Text = "NO.";
            this.lblCard2Value.Click += new System.EventHandler(this.lblCard2Value_Click);
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCard2Title.ForeColor = System.Drawing.Color.Gray;
            this.lblCard2Title.Location = new System.Drawing.Point(15, 61);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(109, 19);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "Today\'s Sessions";
            this.lblCard2Title.Click += new System.EventHandler(this.lblCard2Title_Click);
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.lblCard1Value);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Location = new System.Drawing.Point(17, 15);
            this.pnlCard1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(229, 115);
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
            this.lblCard1Title.Size = new System.Drawing.Size(122, 19);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "Assigned Students";
            this.lblCard1Title.Click += new System.EventHandler(this.lblCard1Title_Click);
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 459);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driving School - Instructor Dashboard";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlDataGrid.ResumeLayout(false);
            this.pnlDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignedSessions)).EndInit();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewAssigned;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Value;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Value;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel pnlDataGrid;
        private System.Windows.Forms.Label lblRecentActivity;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private DataGridView dgvAssignedSessions;
        private LinkLabel linkLabel1;
    }
}