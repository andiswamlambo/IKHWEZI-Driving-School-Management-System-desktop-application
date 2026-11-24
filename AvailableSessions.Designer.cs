namespace Driving_school_login_form
{
    partial class AvailableSessions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlScheduleCard = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblScheduleHeader = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCardTotal = new System.Windows.Forms.Panel();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.pnlCardBooked = new System.Windows.Forms.Panel();
            this.lblBookedCount = new System.Windows.Forms.Label();
            this.lblBookedTitle = new System.Windows.Forms.Label();
            this.pnlCardAvailable = new System.Windows.Forms.Panel();
            this.lblAvailableCount = new System.Windows.Forms.Label();
            this.lblAvailableTitle = new System.Windows.Forms.Label();
            this.pnlCalendarCard = new System.Windows.Forms.Panel();
            this.mcInstructorCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblCalendarHeader = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlScheduleCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.pnlCardTotal.SuspendLayout();
            this.pnlCardBooked.SuspendLayout();
            this.pnlCardAvailable.SuspendLayout();
            this.pnlCalendarCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblSubtitle);
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(960, 60);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopBar_Paint);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(22, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(227, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select a date to view instructor availability";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "AVAILABLE SESSIONS";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.pnlMainContent.Controls.Add(this.pnlScheduleCard);
            this.pnlMainContent.Controls.Add(this.pnlStats);
            this.pnlMainContent.Controls.Add(this.pnlCalendarCard);
            this.pnlMainContent.Controls.Add(this.buttonRefresh);
            this.pnlMainContent.Controls.Add(this.buttonBack);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 60);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(960, 500);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlScheduleCard
            // 
            this.pnlScheduleCard.BackColor = System.Drawing.Color.White;
            this.pnlScheduleCard.Controls.Add(this.dataGridView1);
            this.pnlScheduleCard.Controls.Add(this.lblScheduleHeader);
            this.pnlScheduleCard.Location = new System.Drawing.Point(275, 10);
            this.pnlScheduleCard.Name = "pnlScheduleCard";
            this.pnlScheduleCard.Size = new System.Drawing.Size(670, 450);
            this.pnlScheduleCard.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 405);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblScheduleHeader
            // 
            this.lblScheduleHeader.AutoSize = true;
            this.lblScheduleHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblScheduleHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblScheduleHeader.Location = new System.Drawing.Point(12, 8);
            this.lblScheduleHeader.Name = "lblScheduleHeader";
            this.lblScheduleHeader.Size = new System.Drawing.Size(134, 20);
            this.lblScheduleHeader.TabIndex = 0;
            this.lblScheduleHeader.Text = "Sessions for Today";
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.pnlCardTotal);
            this.pnlStats.Controls.Add(this.pnlCardBooked);
            this.pnlStats.Controls.Add(this.pnlCardAvailable);
            this.pnlStats.Location = new System.Drawing.Point(15, 240);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(250, 90);
            this.pnlStats.TabIndex = 3;
            // 
            // pnlCardTotal
            // 
            this.pnlCardTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.pnlCardTotal.Controls.Add(this.lblTotalCount);
            this.pnlCardTotal.Controls.Add(this.lblTotalTitle);
            this.pnlCardTotal.Location = new System.Drawing.Point(172, 0);
            this.pnlCardTotal.Name = "pnlCardTotal";
            this.pnlCardTotal.Size = new System.Drawing.Size(78, 85);
            this.pnlCardTotal.TabIndex = 2;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblTotalCount.Location = new System.Drawing.Point(18, 8);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(26, 30);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "0";
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalTitle.Location = new System.Drawing.Point(22, 42);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(25, 12);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "Total";
            // 
            // pnlCardBooked
            // 
            this.pnlCardBooked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.pnlCardBooked.Controls.Add(this.lblBookedCount);
            this.pnlCardBooked.Controls.Add(this.lblBookedTitle);
            this.pnlCardBooked.Location = new System.Drawing.Point(86, 0);
            this.pnlCardBooked.Name = "pnlCardBooked";
            this.pnlCardBooked.Size = new System.Drawing.Size(78, 85);
            this.pnlCardBooked.TabIndex = 1;
            // 
            // lblBookedCount
            // 
            this.lblBookedCount.AutoSize = true;
            this.lblBookedCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBookedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblBookedCount.Location = new System.Drawing.Point(18, 8);
            this.lblBookedCount.Name = "lblBookedCount";
            this.lblBookedCount.Size = new System.Drawing.Size(26, 30);
            this.lblBookedCount.TabIndex = 1;
            this.lblBookedCount.Text = "0";
            // 
            // lblBookedTitle
            // 
            this.lblBookedTitle.AutoSize = true;
            this.lblBookedTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblBookedTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblBookedTitle.Location = new System.Drawing.Point(18, 42);
            this.lblBookedTitle.Name = "lblBookedTitle";
            this.lblBookedTitle.Size = new System.Drawing.Size(39, 12);
            this.lblBookedTitle.TabIndex = 0;
            this.lblBookedTitle.Text = "Booked";
            // 
            // pnlCardAvailable
            // 
            this.pnlCardAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(239)))), ((int)(((byte)(223)))));
            this.pnlCardAvailable.Controls.Add(this.lblAvailableCount);
            this.pnlCardAvailable.Controls.Add(this.lblAvailableTitle);
            this.pnlCardAvailable.Location = new System.Drawing.Point(0, 0);
            this.pnlCardAvailable.Name = "pnlCardAvailable";
            this.pnlCardAvailable.Size = new System.Drawing.Size(78, 85);
            this.pnlCardAvailable.TabIndex = 0;
            // 
            // lblAvailableCount
            // 
            this.lblAvailableCount.AutoSize = true;
            this.lblAvailableCount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblAvailableCount.Location = new System.Drawing.Point(14, 8);
            this.lblAvailableCount.Name = "lblAvailableCount";
            this.lblAvailableCount.Size = new System.Drawing.Size(26, 30);
            this.lblAvailableCount.TabIndex = 1;
            this.lblAvailableCount.Text = "0";
            // 
            // lblAvailableTitle
            // 
            this.lblAvailableTitle.AutoSize = true;
            this.lblAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblAvailableTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblAvailableTitle.Location = new System.Drawing.Point(6, 42);
            this.lblAvailableTitle.Name = "lblAvailableTitle";
            this.lblAvailableTitle.Size = new System.Drawing.Size(43, 12);
            this.lblAvailableTitle.TabIndex = 0;
            this.lblAvailableTitle.Text = "Available";
            // 
            // pnlCalendarCard
            // 
            this.pnlCalendarCard.BackColor = System.Drawing.Color.White;
            this.pnlCalendarCard.Controls.Add(this.mcInstructorCalendar);
            this.pnlCalendarCard.Controls.Add(this.lblCalendarHeader);
            this.pnlCalendarCard.Location = new System.Drawing.Point(15, 10);
            this.pnlCalendarCard.Name = "pnlCalendarCard";
            this.pnlCalendarCard.Size = new System.Drawing.Size(250, 220);
            this.pnlCalendarCard.TabIndex = 0;
            // 
            // mcInstructorCalendar
            // 
            this.mcInstructorCalendar.Location = new System.Drawing.Point(15, 35);
            this.mcInstructorCalendar.MaxSelectionCount = 1;
            this.mcInstructorCalendar.Name = "mcInstructorCalendar";
            this.mcInstructorCalendar.TabIndex = 1;
            // 
            // lblCalendarHeader
            // 
            this.lblCalendarHeader.AutoSize = true;
            this.lblCalendarHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblCalendarHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCalendarHeader.Location = new System.Drawing.Point(12, 8);
            this.lblCalendarHeader.Name = "lblCalendarHeader";
            this.lblCalendarHeader.Size = new System.Drawing.Size(97, 20);
            this.lblCalendarHeader.TabIndex = 0;
            this.lblCalendarHeader.Text = "Select a Date";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(115, 345);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 30);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(15, 345);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 30);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AvailableSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 560);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AvailableSessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Sessions - Ikhwezi Driving School";
            this.Load += new System.EventHandler(this.AvailableSessions_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlScheduleCard.ResumeLayout(false);
            this.pnlScheduleCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlCardTotal.ResumeLayout(false);
            this.pnlCardTotal.PerformLayout();
            this.pnlCardBooked.ResumeLayout(false);
            this.pnlCardBooked.PerformLayout();
            this.pnlCardAvailable.ResumeLayout(false);
            this.pnlCardAvailable.PerformLayout();
            this.pnlCalendarCard.ResumeLayout(false);
            this.pnlCalendarCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlCalendarCard;
        private System.Windows.Forms.Label lblCalendarHeader;
        private System.Windows.Forms.MonthCalendar mcInstructorCalendar;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCardAvailable;
        private System.Windows.Forms.Label lblAvailableCount;
        private System.Windows.Forms.Label lblAvailableTitle;
        private System.Windows.Forms.Panel pnlCardBooked;
        private System.Windows.Forms.Label lblBookedCount;
        private System.Windows.Forms.Label lblBookedTitle;
        private System.Windows.Forms.Panel pnlCardTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Panel pnlScheduleCard;
        private System.Windows.Forms.Label lblScheduleHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
