namespace Driving_school_login_form
{
    partial class SignUpForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.LinkLabel();
            this.btnSignUp = new Driving_school_login_form.RoundedButton();
            this.txtConfirmPass = new Driving_school_login_form.RoundedTextBox();
            this.txtPassword = new Driving_school_login_form.RoundedTextBox();
            this.txtExperience = new Driving_school_login_form.RoundedTextBox();
            this.cmbLicence = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtPhone = new Driving_school_login_form.RoundedTextBox();
            this.txtSurname = new Driving_school_login_form.RoundedTextBox();
            this.txtName = new Driving_school_login_form.RoundedTextBox();
            this.txtEmail = new Driving_school_login_form.RoundedTextBox();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Controls.Add(this.btnSignUp);
            this.pnlMain.Controls.Add(this.txtConfirmPass);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Controls.Add(this.txtExperience);
            this.pnlMain.Controls.Add(this.cmbLicence);
            this.pnlMain.Controls.Add(this.cmbRole);
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.txtSurname);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.lblLicence);
            this.pnlMain.Controls.Add(this.lblExperience);
            this.pnlMain.Controls.Add(this.lblConfirmPass);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.lblRole);
            this.pnlMain.Controls.Add(this.lblSurname);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblSubtitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(375, 528);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(165, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ikhwezi";
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.btnBack.Location = new System.Drawing.Point(22, 488);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(166, 17);
            this.btnBack.TabIndex = 21;
            this.btnBack.TabStop = true;
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnBack_LinkClicked);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Blue;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(41, 449);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(300, 37);
            this.btnSignUp.TabIndex = 20;
            this.btnSignUp.Text = "Create Account";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtConfirmPass.BorderRadius = 15;
            this.txtConfirmPass.Location = new System.Drawing.Point(42, 413);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Placeholder = "Confirm Password";
            this.txtConfirmPass.Size = new System.Drawing.Size(300, 32);
            this.txtConfirmPass.TabIndex = 19;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Location = new System.Drawing.Point(42, 362);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Placeholder = "Password";
            this.txtPassword.Size = new System.Drawing.Size(300, 32);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtExperience
            // 
            this.txtExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtExperience.BorderRadius = 15;
            this.txtExperience.Location = new System.Drawing.Point(38, 311);
            this.txtExperience.Margin = new System.Windows.Forms.Padding(2);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Placeholder = "Years of Experience (e.g. 5)";
            this.txtExperience.Size = new System.Drawing.Size(300, 32);
            this.txtExperience.TabIndex = 17;
            this.txtExperience.UseSystemPasswordChar = false;
            this.txtExperience.Visible = false;
            // 
            // cmbLicence
            // 
            this.cmbLicence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbLicence.FormattingEnabled = true;
            this.cmbLicence.Items.AddRange(new object[] {
            "Code 8",
            "Code 10",
            "Code 14"});
            this.cmbLicence.Location = new System.Drawing.Point(41, 268);
            this.cmbLicence.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLicence.Name = "cmbLicence";
            this.cmbLicence.Size = new System.Drawing.Size(301, 24);
            this.cmbLicence.TabIndex = 16;
            this.cmbLicence.Visible = false;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Receptionist",
            "Instructor",
            "Manager"});
            this.cmbRole.Location = new System.Drawing.Point(42, 225);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(301, 24);
            this.cmbRole.TabIndex = 15;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPhone.BorderRadius = 15;
            this.txtPhone.Location = new System.Drawing.Point(38, 174);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Placeholder = "Phone Number (e.g. 0821234567)";
            this.txtPhone.Size = new System.Drawing.Size(300, 32);
            this.txtPhone.TabIndex = 14;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSurname.BorderRadius = 15;
            this.txtSurname.Location = new System.Drawing.Point(43, 123);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Placeholder = "Surname";
            this.txtSurname.Size = new System.Drawing.Size(300, 32);
            this.txtSurname.TabIndex = 13;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtName.BorderRadius = 15;
            this.txtName.Location = new System.Drawing.Point(48, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Placeholder = "Name";
            this.txtName.Size = new System.Drawing.Size(300, 32);
            this.txtName.TabIndex = 12;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.Location = new System.Drawing.Point(43, 28);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Placeholder = "Email Address";
            this.txtEmail.Size = new System.Drawing.Size(300, 32);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicence.Location = new System.Drawing.Point(45, 251);
            this.lblLicence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(91, 15);
            this.lblLicence.TabIndex = 10;
            this.lblLicence.Text = "Licence Type";
            this.lblLicence.Visible = false;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblExperience.Location = new System.Drawing.Point(39, 294);
            this.lblExperience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(135, 15);
            this.lblExperience.TabIndex = 9;
            this.lblExperience.Text = "Years of Experience";
            this.lblExperience.Visible = false;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPass.Location = new System.Drawing.Point(45, 396);
            this.lblConfirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(123, 15);
            this.lblConfirmPass.TabIndex = 8;
            this.lblConfirmPass.Text = "Confirm Password";
            this.lblConfirmPass.Click += new System.EventHandler(this.lblConfirmPass_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(45, 345);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 15);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(45, 157);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(103, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRole.Location = new System.Drawing.Point(45, 208);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(37, 15);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblSurname.Location = new System.Drawing.Point(49, 107);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 15);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname";
            this.lblSurname.Click += new System.EventHandler(this.lblSurname_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(49, 59);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(49, 9);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Red;
            this.lblSubtitle.Location = new System.Drawing.Point(112, 28);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(169, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Staff Registration";
            this.lblSubtitle.Visible = false;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 528);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ikhwezi Driving School - Sign Up";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Driving_school_login_form.RoundedButton btnSignUp;
        private Driving_school_login_form.RoundedTextBox txtConfirmPass;
        private Driving_school_login_form.RoundedTextBox txtPassword;
        private Driving_school_login_form.RoundedTextBox txtExperience;
        private System.Windows.Forms.ComboBox cmbLicence;
        private System.Windows.Forms.ComboBox cmbRole;
        private Driving_school_login_form.RoundedTextBox txtPhone;
        private Driving_school_login_form.RoundedTextBox txtSurname;
        private Driving_school_login_form.RoundedTextBox txtName;
        private Driving_school_login_form.RoundedTextBox txtEmail;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.LinkLabel btnBack;
        private System.Windows.Forms.Label label1;
    }
}