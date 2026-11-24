namespace Driving_school_login_form
{
    partial class Schedule
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.roundedButton2 = new Driving_school_login_form.RoundedButton();
            this.roundedButton1 = new Driving_school_login_form.RoundedButton();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblLegendSelected = new System.Windows.Forms.Label();
            this.lblLegendTaken = new System.Windows.Forms.Label();
            this.lblLegendAvailable = new System.Windows.Forms.Label();
            this.pnlLegendSelectedColor = new System.Windows.Forms.Panel();
            this.pnlLegendTakenColor = new System.Windows.Forms.Panel();
            this.pnlLegendAvailableColor = new System.Windows.Forms.Panel();
            this.grpTimeSlots = new System.Windows.Forms.GroupBox();
            this.lblSlotError = new System.Windows.Forms.Label();
            this.but16 = new System.Windows.Forms.Button();
            this.but15 = new System.Windows.Forms.Button();
            this.but14 = new System.Windows.Forms.Button();
            this.but13 = new System.Windows.Forms.Button();
            this.but12 = new System.Windows.Forms.Button();
            this.but11 = new System.Windows.Forms.Button();
            this.but10 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.grpDateTime = new System.Windows.Forms.GroupBox();
            this.lblDateError = new System.Windows.Forms.Label();
            this.lblDurationError = new System.Windows.Forms.Label();
            this.cmbLessontype = new System.Windows.Forms.ComboBox();
            this.lblLessonType = new System.Windows.Forms.Label();
            this.cboDuration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.grpTimeSlots.SuspendLayout();
            this.grpDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 60);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 40);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(197, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Choose a date, time and lesson type";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(106, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Schedule";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.roundedButton2);
            this.pnlBody.Controls.Add(this.roundedButton1);
            this.pnlBody.Controls.Add(this.pnlLegend);
            this.pnlBody.Controls.Add(this.grpTimeSlots);
            this.pnlBody.Controls.Add(this.grpDateTime);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(550, 410);
            this.pnlBody.TabIndex = 1;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.roundedButton2.BorderRadius = 20;
            this.roundedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(15, 360);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(120, 38);
            this.roundedButton2.TabIndex = 3;
            this.roundedButton2.Text = "Back";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(415, 360);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(120, 38);
            this.roundedButton1.TabIndex = 4;
            this.roundedButton1.Text = "Continue";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.lblSummary);
            this.pnlLegend.Controls.Add(this.lblLegendSelected);
            this.pnlLegend.Controls.Add(this.lblLegendTaken);
            this.pnlLegend.Controls.Add(this.lblLegendAvailable);
            this.pnlLegend.Controls.Add(this.pnlLegendSelectedColor);
            this.pnlLegend.Controls.Add(this.pnlLegendTakenColor);
            this.pnlLegend.Controls.Add(this.pnlLegendAvailableColor);
            this.pnlLegend.Location = new System.Drawing.Point(15, 310);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(520, 35);
            this.pnlLegend.TabIndex = 2;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSummary.ForeColor = System.Drawing.Color.Gray;
            this.lblSummary.Location = new System.Drawing.Point(310, 10);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(108, 13);
            this.lblSummary.TabIndex = 6;
            this.lblSummary.Text = "0 available | 0 taken";
            // 
            // lblLegendSelected
            // 
            this.lblLegendSelected.AutoSize = true;
            this.lblLegendSelected.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLegendSelected.Location = new System.Drawing.Point(230, 10);
            this.lblLegendSelected.Name = "lblLegendSelected";
            this.lblLegendSelected.Size = new System.Drawing.Size(50, 13);
            this.lblLegendSelected.TabIndex = 5;
            this.lblLegendSelected.Text = "Selected";
            // 
            // lblLegendTaken
            // 
            this.lblLegendTaken.AutoSize = true;
            this.lblLegendTaken.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLegendTaken.Location = new System.Drawing.Point(120, 10);
            this.lblLegendTaken.Name = "lblLegendTaken";
            this.lblLegendTaken.Size = new System.Drawing.Size(36, 13);
            this.lblLegendTaken.TabIndex = 4;
            this.lblLegendTaken.Text = "Taken";
            // 
            // lblLegendAvailable
            // 
            this.lblLegendAvailable.AutoSize = true;
            this.lblLegendAvailable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendAvailable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblLegendAvailable.Location = new System.Drawing.Point(18, 10);
            this.lblLegendAvailable.Name = "lblLegendAvailable";
            this.lblLegendAvailable.Size = new System.Drawing.Size(53, 13);
            this.lblLegendAvailable.TabIndex = 3;
            this.lblLegendAvailable.Text = "Available";
            // 
            // pnlLegendSelectedColor
            // 
            this.pnlLegendSelectedColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlLegendSelectedColor.Location = new System.Drawing.Point(210, 8);
            this.pnlLegendSelectedColor.Name = "pnlLegendSelectedColor";
            this.pnlLegendSelectedColor.Size = new System.Drawing.Size(16, 16);
            this.pnlLegendSelectedColor.TabIndex = 2;
            // 
            // pnlLegendTakenColor
            // 
            this.pnlLegendTakenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.pnlLegendTakenColor.Location = new System.Drawing.Point(100, 8);
            this.pnlLegendTakenColor.Name = "pnlLegendTakenColor";
            this.pnlLegendTakenColor.Size = new System.Drawing.Size(16, 16);
            this.pnlLegendTakenColor.TabIndex = 1;
            // 
            // pnlLegendAvailableColor
            // 
            this.pnlLegendAvailableColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlLegendAvailableColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegendAvailableColor.Location = new System.Drawing.Point(0, 8);
            this.pnlLegendAvailableColor.Name = "pnlLegendAvailableColor";
            this.pnlLegendAvailableColor.Size = new System.Drawing.Size(16, 16);
            this.pnlLegendAvailableColor.TabIndex = 0;
            // 
            // grpTimeSlots
            // 
            this.grpTimeSlots.Controls.Add(this.lblSlotError);
            this.grpTimeSlots.Controls.Add(this.but16);
            this.grpTimeSlots.Controls.Add(this.but15);
            this.grpTimeSlots.Controls.Add(this.but14);
            this.grpTimeSlots.Controls.Add(this.but13);
            this.grpTimeSlots.Controls.Add(this.but12);
            this.grpTimeSlots.Controls.Add(this.but11);
            this.grpTimeSlots.Controls.Add(this.but10);
            this.grpTimeSlots.Controls.Add(this.but9);
            this.grpTimeSlots.Controls.Add(this.but8);
            this.grpTimeSlots.Controls.Add(this.but7);
            this.grpTimeSlots.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTimeSlots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpTimeSlots.Location = new System.Drawing.Point(15, 135);
            this.grpTimeSlots.Name = "grpTimeSlots";
            this.grpTimeSlots.Size = new System.Drawing.Size(520, 165);
            this.grpTimeSlots.TabIndex = 1;
            this.grpTimeSlots.TabStop = false;
            this.grpTimeSlots.Text = "Select a Time Slot";
            // 
            // lblSlotError
            // 
            this.lblSlotError.AutoSize = true;
            this.lblSlotError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblSlotError.Location = new System.Drawing.Point(15, 145);
            this.lblSlotError.Name = "lblSlotError";
            this.lblSlotError.Size = new System.Drawing.Size(0, 12);
            this.lblSlotError.TabIndex = 10;
            // 
            // but16
            // 
            this.but16.Location = new System.Drawing.Point(335, 65);
            this.but16.Name = "but16";
            this.but16.Size = new System.Drawing.Size(70, 32);
            this.but16.TabIndex = 9;
            this.but16.Text = "16:00";
            this.but16.UseVisualStyleBackColor = false;
            this.but16.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but15
            // 
            this.but15.Location = new System.Drawing.Point(255, 65);
            this.but15.Name = "but15";
            this.but15.Size = new System.Drawing.Size(70, 32);
            this.but15.TabIndex = 8;
            this.but15.Text = "15:00";
            this.but15.UseVisualStyleBackColor = false;
            this.but15.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but14
            // 
            this.but14.Location = new System.Drawing.Point(175, 65);
            this.but14.Name = "but14";
            this.but14.Size = new System.Drawing.Size(70, 32);
            this.but14.TabIndex = 7;
            this.but14.Text = "14:00";
            this.but14.UseVisualStyleBackColor = false;
            this.but14.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but13
            // 
            this.but13.Location = new System.Drawing.Point(95, 65);
            this.but13.Name = "but13";
            this.but13.Size = new System.Drawing.Size(70, 32);
            this.but13.TabIndex = 6;
            this.but13.Text = "13:00";
            this.but13.UseVisualStyleBackColor = false;
            this.but13.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but12
            // 
            this.but12.Location = new System.Drawing.Point(15, 65);
            this.but12.Name = "but12";
            this.but12.Size = new System.Drawing.Size(70, 32);
            this.but12.TabIndex = 5;
            this.but12.Text = "12:00";
            this.but12.UseVisualStyleBackColor = false;
            this.but12.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but11
            // 
            this.but11.Location = new System.Drawing.Point(335, 25);
            this.but11.Name = "but11";
            this.but11.Size = new System.Drawing.Size(70, 32);
            this.but11.TabIndex = 4;
            this.but11.Text = "11:00";
            this.but11.UseVisualStyleBackColor = false;
            this.but11.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but10
            // 
            this.but10.Location = new System.Drawing.Point(255, 25);
            this.but10.Name = "but10";
            this.but10.Size = new System.Drawing.Size(70, 32);
            this.but10.TabIndex = 3;
            this.but10.Text = "10:00";
            this.but10.UseVisualStyleBackColor = false;
            this.but10.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but9
            // 
            this.but9.Location = new System.Drawing.Point(175, 25);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(70, 32);
            this.but9.TabIndex = 2;
            this.but9.Text = "09:00";
            this.but9.UseVisualStyleBackColor = false;
            this.but9.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but8
            // 
            this.but8.Location = new System.Drawing.Point(95, 25);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(70, 32);
            this.but8.TabIndex = 1;
            this.but8.Text = "08:00";
            this.but8.UseVisualStyleBackColor = false;
            this.but8.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // but7
            // 
            this.but7.Location = new System.Drawing.Point(15, 25);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(70, 32);
            this.but7.TabIndex = 0;
            this.but7.Text = "07:00";
            this.but7.UseVisualStyleBackColor = false;
            this.but7.Click += new System.EventHandler(this.timeSlot_Click);
            // 
            // grpDateTime
            // 
            this.grpDateTime.Controls.Add(this.lblDateError);
            this.grpDateTime.Controls.Add(this.lblDurationError);
            this.grpDateTime.Controls.Add(this.cmbLessontype);
            this.grpDateTime.Controls.Add(this.lblLessonType);
            this.grpDateTime.Controls.Add(this.cboDuration);
            this.grpDateTime.Controls.Add(this.label2);
            this.grpDateTime.Controls.Add(this.dateTimePicker1);
            this.grpDateTime.Controls.Add(this.label3);
            this.grpDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpDateTime.Location = new System.Drawing.Point(15, 10);
            this.grpDateTime.Name = "grpDateTime";
            this.grpDateTime.Size = new System.Drawing.Size(520, 115);
            this.grpDateTime.TabIndex = 0;
            this.grpDateTime.TabStop = false;
            this.grpDateTime.Text = "Date, Duration & Lesson Type";
            // 
            // lblDateError
            // 
            this.lblDateError.AutoSize = true;
            this.lblDateError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDateError.Location = new System.Drawing.Point(15, 95);
            this.lblDateError.Name = "lblDateError";
            this.lblDateError.Size = new System.Drawing.Size(0, 12);
            this.lblDateError.TabIndex = 8;
            this.lblDateError.Visible = false;
            // 
            // lblDurationError
            // 
            this.lblDurationError.AutoSize = true;
            this.lblDurationError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDurationError.Location = new System.Drawing.Point(235, 95);
            this.lblDurationError.Name = "lblDurationError";
            this.lblDurationError.Size = new System.Drawing.Size(0, 12);
            this.lblDurationError.TabIndex = 7;
            this.lblDurationError.Visible = false;
            // 
            // cmbLessontype
            // 
            this.cmbLessontype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbLessontype.FormattingEnabled = true;
            this.cmbLessontype.Location = new System.Drawing.Point(375, 55);
            this.cmbLessontype.Name = "cmbLessontype";
            this.cmbLessontype.Size = new System.Drawing.Size(130, 23);
            this.cmbLessontype.TabIndex = 6;
            // 
            // lblLessonType
            // 
            this.lblLessonType.AutoSize = true;
            this.lblLessonType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLessonType.ForeColor = System.Drawing.Color.Gray;
            this.lblLessonType.Location = new System.Drawing.Point(375, 38);
            this.lblLessonType.Name = "lblLessonType";
            this.lblLessonType.Size = new System.Drawing.Size(67, 13);
            this.lblLessonType.TabIndex = 5;
            this.lblLessonType.Text = "Lesson Type";
            // 
            // cboDuration
            // 
            this.cboDuration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboDuration.FormattingEnabled = true;
            this.cboDuration.Location = new System.Drawing.Point(235, 55);
            this.cboDuration.Name = "cboDuration";
            this.cboDuration.Size = new System.Drawing.Size(125, 23);
            this.cboDuration.TabIndex = 4;
            this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.cboDuration_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(235, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duration";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select Date";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 470);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule - Ikhwezi Driving School";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.grpTimeSlots.ResumeLayout(false);
            this.grpTimeSlots.PerformLayout();
            this.grpDateTime.ResumeLayout(false);
            this.grpDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpDateTime;
        private System.Windows.Forms.GroupBox grpTimeSlots;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLessontype;
        private System.Windows.Forms.Label lblLessonType;
        private System.Windows.Forms.Label lblDateError;
        private System.Windows.Forms.Label lblDurationError;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but10;
        private System.Windows.Forms.Button but11;
        private System.Windows.Forms.Button but12;
        private System.Windows.Forms.Button but13;
        private System.Windows.Forms.Button but14;
        private System.Windows.Forms.Button but15;
        private System.Windows.Forms.Button but16;
        private System.Windows.Forms.Label lblSlotError;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlLegendAvailableColor;
        private System.Windows.Forms.Panel pnlLegendTakenColor;
        private System.Windows.Forms.Panel pnlLegendSelectedColor;
        private System.Windows.Forms.Label lblLegendAvailable;
        private System.Windows.Forms.Label lblLegendTaken;
        private System.Windows.Forms.Label lblLegendSelected;
        private System.Windows.Forms.Label lblSummary;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}