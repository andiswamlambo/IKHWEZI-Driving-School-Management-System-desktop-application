namespace Driving_school_login_form
{
    partial class NewBooking
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
            this.grpPackage = new System.Windows.Forms.GroupBox();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblPackageError = new System.Windows.Forms.Label();
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.lblStudentFound = new System.Windows.Forms.Label();
            this.txtSurname = new Driving_school_login_form.RoundedTextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new Driving_school_login_form.RoundedTextBox();
            this.txtName = new Driving_school_login_form.RoundedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblPhoneHint = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpPackage.SuspendLayout();
            this.grpStudent.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(480, 65);
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
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(208, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Enter student details to begin booking";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(151, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "New Booking";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.roundedButton2);
            this.pnlBody.Controls.Add(this.roundedButton1);
            this.pnlBody.Controls.Add(this.grpPackage);
            this.pnlBody.Controls.Add(this.grpStudent);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 65);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(480, 385);
            this.pnlBody.TabIndex = 1;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
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
            this.roundedButton2.Location = new System.Drawing.Point(15, 318);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(120, 40);
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
            this.roundedButton1.Location = new System.Drawing.Point(345, 318);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(120, 40);
            this.roundedButton1.TabIndex = 3;
            this.roundedButton1.Text = "Continue";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // grpPackage
            // 
            this.grpPackage.Controls.Add(this.cmbPackage);
            this.grpPackage.Controls.Add(this.lblPackage);
            this.grpPackage.Controls.Add(this.lblPackageError);
            this.grpPackage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpPackage.Location = new System.Drawing.Point(15, 235);
            this.grpPackage.Name = "grpPackage";
            this.grpPackage.Size = new System.Drawing.Size(450, 65);
            this.grpPackage.TabIndex = 1;
            this.grpPackage.TabStop = false;
            this.grpPackage.Text = "Select Package";
            // 
            // cmbPackage
            // 
            this.cmbPackage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(20, 30);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(410, 25);
            this.cmbPackage.TabIndex = 5;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPackage.ForeColor = System.Drawing.Color.Gray;
            this.lblPackage.Location = new System.Drawing.Point(20, 15);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(0, 13);
            this.lblPackage.TabIndex = 0;
            // 
            // lblPackageError
            // 
            this.lblPackageError.AutoSize = true;
            this.lblPackageError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblPackageError.Location = new System.Drawing.Point(20, 55);
            this.lblPackageError.Name = "lblPackageError";
            this.lblPackageError.Size = new System.Drawing.Size(0, 12);
            this.lblPackageError.TabIndex = 1;
            this.lblPackageError.Visible = false;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.lblStudentFound);
            this.grpStudent.Controls.Add(this.txtSurname);
            this.grpStudent.Controls.Add(this.lblSurname);
            this.grpStudent.Controls.Add(this.txtPhone);
            this.grpStudent.Controls.Add(this.txtEmail);
            this.grpStudent.Controls.Add(this.txtName);
            this.grpStudent.Controls.Add(this.lblPhone);
            this.grpStudent.Controls.Add(this.lblEmail);
            this.grpStudent.Controls.Add(this.lblName);
            this.grpStudent.Controls.Add(this.lblNameError);
            this.grpStudent.Controls.Add(this.lblEmailError);
            this.grpStudent.Controls.Add(this.lblPhoneError);
            this.grpStudent.Controls.Add(this.lblPhoneHint);
            this.grpStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpStudent.Location = new System.Drawing.Point(15, 10);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(450, 215);
            this.grpStudent.TabIndex = 0;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Student Details";
            // 
            // lblStudentFound
            // 
            this.lblStudentFound.AutoSize = true;
            this.lblStudentFound.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblStudentFound.Location = new System.Drawing.Point(350, 95);
            this.lblStudentFound.Name = "lblStudentFound";
            this.lblStudentFound.Size = new System.Drawing.Size(0, 13);
            this.lblStudentFound.TabIndex = 15;
            this.lblStudentFound.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtSurname.BorderRadius = 8;
            this.txtSurname.Location = new System.Drawing.Point(232, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Placeholder = "Surname";
            this.txtSurname.Size = new System.Drawing.Size(200, 31);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblSurname.Location = new System.Drawing.Point(230, 48);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 14;
            this.lblSurname.Text = "Surname";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(20, 135);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 25);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Location = new System.Drawing.Point(232, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "demo@example.invalid";
            this.txtEmail.Size = new System.Drawing.Size(200, 31);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtName.BorderRadius = 8;
            this.txtName.Location = new System.Drawing.Point(20, 65);
            this.txtName.Name = "txtName";
            this.txtName.Placeholder = "First Name";
            this.txtName.Size = new System.Drawing.Size(200, 31);
            this.txtName.TabIndex = 1;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(20, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(93, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone (10 digits)";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(230, 113);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(20, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "First Name";
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblNameError.Location = new System.Drawing.Point(20, 98);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 12);
            this.lblNameError.TabIndex = 8;
            this.lblNameError.Visible = false;
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblEmailError.Location = new System.Drawing.Point(230, 138);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 12);
            this.lblEmailError.TabIndex = 9;
            this.lblEmailError.Visible = false;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblPhoneError.Location = new System.Drawing.Point(20, 162);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 12);
            this.lblPhoneError.TabIndex = 10;
            this.lblPhoneError.Visible = false;
            // 
            // lblPhoneHint
            // 
            this.lblPhoneHint.AutoSize = true;
            this.lblPhoneHint.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblPhoneHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblPhoneHint.Location = new System.Drawing.Point(20, 176);
            this.lblPhoneHint.Name = "lblPhoneHint";
            this.lblPhoneHint.Size = new System.Drawing.Size(117, 12);
            this.lblPhoneHint.TabIndex = 16;
            this.lblPhoneHint.Text = "e.g. 0723456789 (10 digits)";
            // 
            // NewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Booking - Ikhwezi Driving School";
            this.Load += new System.EventHandler(this.NewBooking_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.grpPackage.ResumeLayout(false);
            this.grpPackage.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.GroupBox grpPackage;
        private RoundedTextBox txtName;
        private RoundedTextBox txtSurname;
        private RoundedTextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblPackageError;
        private System.Windows.Forms.Label lblPhoneHint;
        private System.Windows.Forms.Label lblStudentFound;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
    }
}