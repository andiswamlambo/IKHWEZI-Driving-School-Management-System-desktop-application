namespace Driving_school_login_form
{
    partial class LessonStatusForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpLessonDetails;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.CheckBox chkShowStudentNumber;
        private System.Windows.Forms.Label lblSelectLesson;
        private System.Windows.Forms.ComboBox cmbLessons;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.TextBox txtCurrentStatus;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button button1;

        // Reschedule Panel Controls
        private System.Windows.Forms.Panel pnlReschedule;
        private System.Windows.Forms.Label lblRescheduleInfo;
        private System.Windows.Forms.Label lblRescheduleDate;
        private System.Windows.Forms.DateTimePicker dtpRescheduleDate;
        private System.Windows.Forms.Label lblRescheduleTime;
        private System.Windows.Forms.DateTimePicker dtpRescheduleTime;
        private System.Windows.Forms.Button btnReschedule;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpLessonDetails = new System.Windows.Forms.GroupBox();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.chkShowStudentNumber = new System.Windows.Forms.CheckBox();
            this.lblSelectLesson = new System.Windows.Forms.Label();
            this.cmbLessons = new System.Windows.Forms.ComboBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlReschedule = new System.Windows.Forms.Panel();
            this.lblRescheduleInfo = new System.Windows.Forms.Label();
            this.lblRescheduleDate = new System.Windows.Forms.Label();
            this.dtpRescheduleDate = new System.Windows.Forms.DateTimePicker();
            this.lblRescheduleTime = new System.Windows.Forms.Label();
            this.dtpRescheduleTime = new System.Windows.Forms.DateTimePicker();
            this.btnReschedule = new System.Windows.Forms.Button();
            this.grpLessonDetails.SuspendLayout();
            this.pnlReschedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(220, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Lesson Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(220, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 3);
            this.panel1.TabIndex = 1;
            // 
            // grpLessonDetails
            // 
            this.grpLessonDetails.Controls.Add(this.lblSelectStudent);
            this.grpLessonDetails.Controls.Add(this.cmbStudents);
            this.grpLessonDetails.Controls.Add(this.chkShowStudentNumber);
            this.grpLessonDetails.Controls.Add(this.lblSelectLesson);
            this.grpLessonDetails.Controls.Add(this.cmbLessons);
            this.grpLessonDetails.Controls.Add(this.lblCurrentStatus);
            this.grpLessonDetails.Controls.Add(this.txtCurrentStatus);
            this.grpLessonDetails.Controls.Add(this.lblNewStatus);
            this.grpLessonDetails.Controls.Add(this.cmbNewStatus);
            this.grpLessonDetails.Controls.Add(this.btnUpdateStatus);
            this.grpLessonDetails.Controls.Add(this.lblMessage);
            this.grpLessonDetails.Location = new System.Drawing.Point(120, 90);
            this.grpLessonDetails.Name = "grpLessonDetails";
            this.grpLessonDetails.Size = new System.Drawing.Size(550, 310);
            this.grpLessonDetails.TabIndex = 2;
            this.grpLessonDetails.TabStop = false;
            this.grpLessonDetails.Text = "Lesson Details";
            this.grpLessonDetails.Enter += new System.EventHandler(this.grpLessonDetails_Enter);
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Location = new System.Drawing.Point(25, 40);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(80, 13);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select Student:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(150, 37);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(320, 21);
            this.cmbStudents.TabIndex = 1;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // chkShowStudentNumber
            // 
            this.chkShowStudentNumber.AutoSize = true;
            this.chkShowStudentNumber.Location = new System.Drawing.Point(150, 64);
            this.chkShowStudentNumber.Name = "chkShowStudentNumber";
            this.chkShowStudentNumber.Size = new System.Drawing.Size(141, 17);
            this.chkShowStudentNumber.TabIndex = 10;
            this.chkShowStudentNumber.Text = "Include Student Number";
            this.chkShowStudentNumber.CheckedChanged += new System.EventHandler(this.chkShowStudentNumber_CheckedChanged);
            // 
            // lblSelectLesson
            // 
            this.lblSelectLesson.AutoSize = true;
            this.lblSelectLesson.Location = new System.Drawing.Point(25, 95);
            this.lblSelectLesson.Name = "lblSelectLesson";
            this.lblSelectLesson.Size = new System.Drawing.Size(77, 13);
            this.lblSelectLesson.TabIndex = 2;
            this.lblSelectLesson.Text = "Select Lesson:";
            // 
            // cmbLessons
            // 
            this.cmbLessons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLessons.FormattingEnabled = true;
            this.cmbLessons.Location = new System.Drawing.Point(150, 92);
            this.cmbLessons.Name = "cmbLessons";
            this.cmbLessons.Size = new System.Drawing.Size(320, 21);
            this.cmbLessons.TabIndex = 3;
            this.cmbLessons.SelectedIndexChanged += new System.EventHandler(this.cmbLessons_SelectedIndexChanged);
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(25, 140);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentStatus.TabIndex = 4;
            this.lblCurrentStatus.Text = "Current Status";
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Location = new System.Drawing.Point(150, 137);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.ReadOnly = true;
            this.txtCurrentStatus.Size = new System.Drawing.Size(320, 20);
            this.txtCurrentStatus.TabIndex = 5;
            this.txtCurrentStatus.TextChanged += new System.EventHandler(this.txtCurrentStatus_TextChanged);
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(25, 185);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(62, 13);
            this.lblNewStatus.TabIndex = 6;
            this.lblNewStatus.Text = "New Status";
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Items.AddRange(new object[] {
            "Pending",
            "Completed",
            "Cancelled",
            "Rescheduled"});
            this.cmbNewStatus.Location = new System.Drawing.Point(150, 182);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(320, 21);
            this.cmbNewStatus.TabIndex = 7;
            this.cmbNewStatus.SelectedIndexChanged += new System.EventHandler(this.cmbNewStatus_SelectedIndexChanged);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(150, 230);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(320, 40);
            this.btnUpdateStatus.TabIndex = 8;
            this.btnUpdateStatus.Text = "Update Status Only";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            this.btnUpdateStatus.MouseEnter += new System.EventHandler(this.btnUpdateStatus_MouseEnter);
            this.btnUpdateStatus.MouseLeave += new System.EventHandler(this.btnUpdateStatus_MouseLeave);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(150, 285);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlReschedule
            // 
            this.pnlReschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlReschedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReschedule.Controls.Add(this.lblRescheduleInfo);
            this.pnlReschedule.Controls.Add(this.lblRescheduleDate);
            this.pnlReschedule.Controls.Add(this.dtpRescheduleDate);
            this.pnlReschedule.Controls.Add(this.lblRescheduleTime);
            this.pnlReschedule.Controls.Add(this.dtpRescheduleTime);
            this.pnlReschedule.Controls.Add(this.btnReschedule);
            this.pnlReschedule.Location = new System.Drawing.Point(120, 410);
            this.pnlReschedule.Name = "pnlReschedule";
            this.pnlReschedule.Size = new System.Drawing.Size(550, 120);
            this.pnlReschedule.TabIndex = 4;
            this.pnlReschedule.Visible = false;
            // 
            // lblRescheduleInfo
            // 
            this.lblRescheduleInfo.AutoSize = true;
            this.lblRescheduleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRescheduleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRescheduleInfo.Location = new System.Drawing.Point(15, 10);
            this.lblRescheduleInfo.Name = "lblRescheduleInfo";
            this.lblRescheduleInfo.Size = new System.Drawing.Size(231, 15);
            this.lblRescheduleInfo.TabIndex = 0;
            this.lblRescheduleInfo.Text = "Please select a new date and time.";
            // 
            // lblRescheduleDate
            // 
            this.lblRescheduleDate.AutoSize = true;
            this.lblRescheduleDate.Location = new System.Drawing.Point(15, 45);
            this.lblRescheduleDate.Name = "lblRescheduleDate";
            this.lblRescheduleDate.Size = new System.Drawing.Size(58, 13);
            this.lblRescheduleDate.TabIndex = 1;
            this.lblRescheduleDate.Text = "New Date:";
            // 
            // dtpRescheduleDate
            // 
            this.dtpRescheduleDate.Location = new System.Drawing.Point(90, 41);
            this.dtpRescheduleDate.Name = "dtpRescheduleDate";
            this.dtpRescheduleDate.Size = new System.Drawing.Size(200, 20);
            this.dtpRescheduleDate.TabIndex = 2;
            // 
            // lblRescheduleTime
            // 
            this.lblRescheduleTime.AutoSize = true;
            this.lblRescheduleTime.Location = new System.Drawing.Point(15, 75);
            this.lblRescheduleTime.Name = "lblRescheduleTime";
            this.lblRescheduleTime.Size = new System.Drawing.Size(58, 13);
            this.lblRescheduleTime.TabIndex = 3;
            this.lblRescheduleTime.Text = "New Time:";
            // 
            // dtpRescheduleTime
            // 
            this.dtpRescheduleTime.CustomFormat = "HH:mm";
            this.dtpRescheduleTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRescheduleTime.Location = new System.Drawing.Point(90, 71);
            this.dtpRescheduleTime.Name = "dtpRescheduleTime";
            this.dtpRescheduleTime.ShowUpDown = true;
            this.dtpRescheduleTime.Size = new System.Drawing.Size(200, 20);
            this.dtpRescheduleTime.TabIndex = 4;
            // 
            // btnReschedule
            // 
            this.btnReschedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.btnReschedule.ForeColor = System.Drawing.Color.White;
            this.btnReschedule.Location = new System.Drawing.Point(350, 50);
            this.btnReschedule.Name = "btnReschedule";
            this.btnReschedule.Size = new System.Drawing.Size(170, 40);
            this.btnReschedule.TabIndex = 5;
            this.btnReschedule.Text = "Reschedule Lesson";
            this.btnReschedule.UseVisualStyleBackColor = false;
            this.btnReschedule.Click += new System.EventHandler(this.btnReschedule_Click);
            this.btnReschedule.MouseEnter += new System.EventHandler(this.btnReschedule_MouseEnter);
            this.btnReschedule.MouseLeave += new System.EventHandler(this.btnReschedule_MouseLeave);
            // 
            // LessonStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnlReschedule);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpLessonDetails);
            this.Controls.Add(this.button1);
            this.Name = "LessonStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lesson Status";
            this.Load += new System.EventHandler(this.LessonStatusForm_Load);
            this.grpLessonDetails.ResumeLayout(false);
            this.grpLessonDetails.PerformLayout();
            this.pnlReschedule.ResumeLayout(false);
            this.pnlReschedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void grpLessonDetails_Enter(object sender, System.EventArgs e)
        {

        }
    }
}