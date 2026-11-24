namespace Driving_school_login_form
{
    partial class ConfirmBooking
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
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblBookingDateValue = new System.Windows.Forms.Label();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblInstructorValue = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblVehicleValue = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblDurationValue = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDateTimeValue = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPackageValue = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStudentValue = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlSummary.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(500, 60);
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
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(169, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Review the details and confirm";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(187, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Confirm Booking";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.roundedButton2);
            this.pnlBody.Controls.Add(this.roundedButton1);
            this.pnlBody.Controls.Add(this.pnlSummary);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(500, 400);
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
            this.roundedButton2.Location = new System.Drawing.Point(20, 340);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(120, 38);
            this.roundedButton2.TabIndex = 2;
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
            this.roundedButton1.Location = new System.Drawing.Point(360, 340);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(120, 38);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "Confirm";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblBookingDateValue);
            this.pnlSummary.Controls.Add(this.lblBookingDate);
            this.pnlSummary.Controls.Add(this.lblInstructorValue);
            this.pnlSummary.Controls.Add(this.lblInstructor);
            this.pnlSummary.Controls.Add(this.lblVehicleValue);
            this.pnlSummary.Controls.Add(this.lblVehicle);
            this.pnlSummary.Controls.Add(this.lblDurationValue);
            this.pnlSummary.Controls.Add(this.lblDuration);
            this.pnlSummary.Controls.Add(this.lblDateTimeValue);
            this.pnlSummary.Controls.Add(this.lblDateTime);
            this.pnlSummary.Controls.Add(this.lblPackageValue);
            this.pnlSummary.Controls.Add(this.lblPackage);
            this.pnlSummary.Controls.Add(this.lblEmailValue);
            this.pnlSummary.Controls.Add(this.lblEmail);
            this.pnlSummary.Controls.Add(this.lblStudentValue);
            this.pnlSummary.Controls.Add(this.lblStudent);
            this.pnlSummary.Location = new System.Drawing.Point(20, 15);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(460, 310);
            this.pnlSummary.TabIndex = 0;
            // 
            // lblBookingDateValue
            // 
            this.lblBookingDateValue.AutoSize = true;
            this.lblBookingDateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingDateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblBookingDateValue.Location = new System.Drawing.Point(160, 260);
            this.lblBookingDateValue.Name = "lblBookingDateValue";
            this.lblBookingDateValue.Size = new System.Drawing.Size(0, 19);
            this.lblBookingDateValue.TabIndex = 15;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.lblBookingDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBookingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBookingDate.Location = new System.Drawing.Point(15, 260);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(84, 19);
            this.lblBookingDate.TabIndex = 14;
            this.lblBookingDate.Text = "Booked On";
            // 
            // lblInstructorValue
            // 
            this.lblInstructorValue.AutoSize = true;
            this.lblInstructorValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstructorValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblInstructorValue.Location = new System.Drawing.Point(160, 225);
            this.lblInstructorValue.Name = "lblInstructorValue";
            this.lblInstructorValue.Size = new System.Drawing.Size(0, 19);
            this.lblInstructorValue.TabIndex = 13;
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblInstructor.Location = new System.Drawing.Point(15, 225);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(73, 19);
            this.lblInstructor.TabIndex = 12;
            this.lblInstructor.Text = "Instructor";
            // 
            // lblVehicleValue
            // 
            this.lblVehicleValue.AutoSize = true;
            this.lblVehicleValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVehicleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblVehicleValue.Location = new System.Drawing.Point(160, 190);
            this.lblVehicleValue.Name = "lblVehicleValue";
            this.lblVehicleValue.Size = new System.Drawing.Size(0, 19);
            this.lblVehicleValue.TabIndex = 11;
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblVehicle.Location = new System.Drawing.Point(15, 190);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(56, 19);
            this.lblVehicle.TabIndex = 10;
            this.lblVehicle.Text = "Vehicle";
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.AutoSize = true;
            this.lblDurationValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDurationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDurationValue.Location = new System.Drawing.Point(160, 155);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(0, 19);
            this.lblDurationValue.TabIndex = 9;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDuration.Location = new System.Drawing.Point(15, 155);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(67, 19);
            this.lblDuration.TabIndex = 8;
            this.lblDuration.Text = "Duration";
            // 
            // lblDateTimeValue
            // 
            this.lblDateTimeValue.AutoSize = true;
            this.lblDateTimeValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTimeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDateTimeValue.Location = new System.Drawing.Point(160, 120);
            this.lblDateTimeValue.Name = "lblDateTimeValue";
            this.lblDateTimeValue.Size = new System.Drawing.Size(0, 19);
            this.lblDateTimeValue.TabIndex = 7;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDateTime.Location = new System.Drawing.Point(15, 120);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(81, 19);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "Date & Time";
            // 
            // lblPackageValue
            // 
            this.lblPackageValue.AutoSize = true;
            this.lblPackageValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPackageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblPackageValue.Location = new System.Drawing.Point(160, 85);
            this.lblPackageValue.Name = "lblPackageValue";
            this.lblPackageValue.Size = new System.Drawing.Size(0, 19);
            this.lblPackageValue.TabIndex = 5;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPackage.Location = new System.Drawing.Point(15, 85);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(66, 19);
            this.lblPackage.TabIndex = 4;
            this.lblPackage.Text = "Package";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblEmailValue.Location = new System.Drawing.Point(160, 50);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(0, 19);
            this.lblEmailValue.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEmail.Location = new System.Drawing.Point(15, 50);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblStudentValue
            // 
            this.lblStudentValue.AutoSize = true;
            this.lblStudentValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStudentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStudentValue.Location = new System.Drawing.Point(160, 15);
            this.lblStudentValue.Name = "lblStudentValue";
            this.lblStudentValue.Size = new System.Drawing.Size(0, 19);
            this.lblStudentValue.TabIndex = 1;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStudent.Location = new System.Drawing.Point(15, 15);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(60, 19);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student";
            // 
            // ConfirmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 460);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Booking - Ikhwezi Driving School";
            this.Load += new System.EventHandler(this.ConfirmBooking_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblStudentValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblPackageValue;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDateTimeValue;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationValue;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblVehicleValue;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Label lblInstructorValue;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.Label lblBookingDateValue;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}