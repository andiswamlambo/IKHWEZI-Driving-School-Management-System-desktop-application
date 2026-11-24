using System;
using System.Windows.Forms;

namespace Driving_school_login_form

{
    partial class ForgotPasswordForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.linkBackToLogin = new System.Windows.Forms.LinkLabel();
            this.roundedButton3 = new Driving_school_login_form.RoundedButton();
            this.roundedTextBox4 = new Driving_school_login_form.RoundedTextBox();
            this.roundedButton2 = new Driving_school_login_form.RoundedButton();
            this.roundedButton1 = new Driving_school_login_form.RoundedButton();
            this.roundedTextBox3 = new Driving_school_login_form.RoundedTextBox();
            this.roundedTextBox2 = new Driving_school_login_form.RoundedTextBox();
            this.roundedTextBox1 = new Driving_school_login_form.RoundedTextBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnShowConfirmPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(34, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 30);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Forgot Password";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lblInstructions.Location = new System.Drawing.Point(36, 61);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(250, 15);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Step 1: Enter your email to verify your account";
            // 
            // linkBackToLogin
            // 
            this.linkBackToLogin.AutoSize = true;
            this.linkBackToLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkBackToLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkBackToLogin.LinkColor = System.Drawing.Color.Gray;
            this.linkBackToLogin.Location = new System.Drawing.Point(36, 474);
            this.linkBackToLogin.Name = "linkBackToLogin";
            this.linkBackToLogin.Size = new System.Drawing.Size(79, 15);
            this.linkBackToLogin.TabIndex = 0;
            this.linkBackToLogin.TabStop = true;
            this.linkBackToLogin.Text = "Back to Login";
            this.linkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackToLogin_LinkClicked_1);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.roundedButton3.BorderRadius = 20;
            this.roundedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(39, 244);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(257, 40);
            this.roundedButton3.TabIndex = 14;
            this.roundedButton3.Text = "verify code";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedTextBox4
            // 
            this.roundedTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundedTextBox4.BorderRadius = 15;
            this.roundedTextBox4.Location = new System.Drawing.Point(39, 193);
            this.roundedTextBox4.Name = "roundedTextBox4";
            this.roundedTextBox4.Placeholder = "verification code";
            this.roundedTextBox4.Size = new System.Drawing.Size(257, 30);
            this.roundedTextBox4.TabIndex = 13;
            this.roundedTextBox4.UseSystemPasswordChar = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.DarkBlue;
            this.roundedButton2.BorderRadius = 20;
            this.roundedButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(39, 413);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(257, 40);
            this.roundedButton2.TabIndex = 12;
            this.roundedButton2.Text = "update password";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.DarkBlue;
            this.roundedButton1.BorderRadius = 20;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(39, 125);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(257, 40);
            this.roundedButton1.TabIndex = 11;
            this.roundedButton1.Text = "verify email";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click_1);
            // 
            // roundedTextBox3
            // 
            this.roundedTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundedTextBox3.BorderRadius = 15;
            this.roundedTextBox3.Location = new System.Drawing.Point(39, 363);
            this.roundedTextBox3.Name = "roundedTextBox3";
            this.roundedTextBox3.Placeholder = "confirm password";
            this.roundedTextBox3.Size = new System.Drawing.Size(257, 30);
            this.roundedTextBox3.TabIndex = 10;
            this.roundedTextBox3.UseSystemPasswordChar = false;
            // 
            // roundedTextBox2
            // 
            this.roundedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundedTextBox2.BorderRadius = 15;
            this.roundedTextBox2.Location = new System.Drawing.Point(39, 307);
            this.roundedTextBox2.Name = "roundedTextBox2";
            this.roundedTextBox2.Placeholder = "new password";
            this.roundedTextBox2.Size = new System.Drawing.Size(257, 30);
            this.roundedTextBox2.TabIndex = 9;
            this.roundedTextBox2.UseSystemPasswordChar = false;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundedTextBox1.BorderRadius = 15;
            this.roundedTextBox1.Location = new System.Drawing.Point(39, 79);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Placeholder = "demo@example.invalid";
            this.roundedTextBox1.Size = new System.Drawing.Size(257, 30);
            this.roundedTextBox1.TabIndex = 8;
            this.roundedTextBox1.UseSystemPasswordChar = false;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(303, 313);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(16, 24);
            this.btnShowPassword.TabIndex = 15;
            this.btnShowPassword.Text = "👁";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(303, 370);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(16, 23);
            this.btnShowConfirmPassword.TabIndex = 16;
            this.btnShowConfirmPassword.Text = "👁";
            this.btnShowConfirmPassword.UseVisualStyleBackColor = true;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.btnShowConfirmPassword_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 498);
            this.Controls.Add(this.btnShowConfirmPassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedTextBox4);
            this.Controls.Add(this.roundedButton2);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.roundedTextBox3);
            this.Controls.Add(this.roundedTextBox2);
            this.Controls.Add(this.roundedTextBox1);
            this.Controls.Add(this.linkBackToLogin);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.LinkLabel linkBackToLogin;
        private EventHandler btnVerify_Click;
        private EventHandler btnUpdate_Click;
        //private LinkLabelLinkClickedEventHandler linkBackToLogin_LinkClicked;
        private RoundedTextBox roundedTextBox1;
        private RoundedTextBox roundedTextBox2;
        private RoundedTextBox roundedTextBox3;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private RoundedTextBox roundedTextBox4;
        private RoundedButton roundedButton3;
        private Button btnShowPassword;
        private Button btnShowConfirmPassword;
    }
}