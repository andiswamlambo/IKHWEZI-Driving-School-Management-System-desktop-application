namespace Driving_school_login_form
{
    partial class Transactions
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.EmailtextBox1 = new System.Windows.Forms.TextBox();
            this.labelNames = new System.Windows.Forms.Label();
            this.namestextBox3 = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.phonetextBox2 = new System.Windows.Forms.TextBox();
            this.packageGroupBox = new System.Windows.Forms.GroupBox();
            this.labelPackage = new System.Windows.Forms.Label();
            this.packagetextBox1 = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.vehiclegatergorytextBox3 = new System.Windows.Forms.TextBox();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.labelPayID = new System.Windows.Forms.Label();
            this.paymentIDtextBox6 = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.amounttextBox5 = new System.Windows.Forms.TextBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.methodtextBox4 = new System.Windows.Forms.TextBox();
            this.lessonGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.printbutton1 = new System.Windows.Forms.Button();
            this.emailbutton3 = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.studentGroupBox.SuspendLayout();
            this.packageGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.lessonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 8);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(431, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "IKHWEZI DRIVING SCHOOL — TRANSACTIONS";
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(12, 36);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1060, 2);
            this.separator1.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(60, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(220, 23);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(286, 43);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 26);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterLabel.Location = new System.Drawing.Point(385, 48);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(42, 15);
            this.filterLabel.TabIndex = 4;
            this.filterLabel.Text = "Status:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterComboBox.Location = new System.Drawing.Point(428, 44);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(120, 23);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(560, 43);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(80, 26);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 155);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.labelEmail);
            this.studentGroupBox.Controls.Add(this.EmailtextBox1);
            this.studentGroupBox.Controls.Add(this.labelNames);
            this.studentGroupBox.Controls.Add(this.namestextBox3);
            this.studentGroupBox.Controls.Add(this.labelPhone);
            this.studentGroupBox.Controls.Add(this.phonetextBox2);
            this.studentGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.studentGroupBox.Location = new System.Drawing.Point(12, 238);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(355, 95);
            this.studentGroupBox.TabIndex = 8;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student Details";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelEmail.Location = new System.Drawing.Point(10, 18);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(34, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // EmailtextBox1
            // 
            this.EmailtextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailtextBox1.Location = new System.Drawing.Point(10, 34);
            this.EmailtextBox1.Name = "EmailtextBox1";
            this.EmailtextBox1.ReadOnly = true;
            this.EmailtextBox1.Size = new System.Drawing.Size(155, 23);
            this.EmailtextBox1.TabIndex = 1;
            // 
            // labelNames
            // 
            this.labelNames.AutoSize = true;
            this.labelNames.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelNames.Location = new System.Drawing.Point(175, 18);
            this.labelNames.Name = "labelNames";
            this.labelNames.Size = new System.Drawing.Size(63, 13);
            this.labelNames.TabIndex = 2;
            this.labelNames.Text = "Full Names";
            // 
            // namestextBox3
            // 
            this.namestextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.namestextBox3.Location = new System.Drawing.Point(175, 34);
            this.namestextBox3.Name = "namestextBox3";
            this.namestextBox3.ReadOnly = true;
            this.namestextBox3.Size = new System.Drawing.Size(165, 23);
            this.namestextBox3.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelPhone.Location = new System.Drawing.Point(10, 60);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(84, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone Number";
            // 
            // phonetextBox2
            // 
            this.phonetextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonetextBox2.Location = new System.Drawing.Point(10, 73);
            this.phonetextBox2.Name = "phonetextBox2";
            this.phonetextBox2.ReadOnly = true;
            this.phonetextBox2.Size = new System.Drawing.Size(330, 23);
            this.phonetextBox2.TabIndex = 5;
            // 
            // packageGroupBox
            // 
            this.packageGroupBox.Controls.Add(this.labelPackage);
            this.packageGroupBox.Controls.Add(this.packagetextBox1);
            this.packageGroupBox.Controls.Add(this.labelCategory);
            this.packageGroupBox.Controls.Add(this.vehiclegatergorytextBox3);
            this.packageGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.packageGroupBox.Location = new System.Drawing.Point(375, 238);
            this.packageGroupBox.Name = "packageGroupBox";
            this.packageGroupBox.Size = new System.Drawing.Size(340, 95);
            this.packageGroupBox.TabIndex = 9;
            this.packageGroupBox.TabStop = false;
            this.packageGroupBox.Text = "Package Details";
            // 
            // labelPackage
            // 
            this.labelPackage.AutoSize = true;
            this.labelPackage.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelPackage.Location = new System.Drawing.Point(10, 18);
            this.labelPackage.Name = "labelPackage";
            this.labelPackage.Size = new System.Drawing.Size(49, 13);
            this.labelPackage.TabIndex = 0;
            this.labelPackage.Text = "Package";
            // 
            // packagetextBox1
            // 
            this.packagetextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.packagetextBox1.Location = new System.Drawing.Point(10, 34);
            this.packagetextBox1.Name = "packagetextBox1";
            this.packagetextBox1.ReadOnly = true;
            this.packagetextBox1.Size = new System.Drawing.Size(150, 23);
            this.packagetextBox1.TabIndex = 1;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelCategory.Location = new System.Drawing.Point(170, 18);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(92, 13);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Vehicle Category";
            // 
            // vehiclegatergorytextBox3
            // 
            this.vehiclegatergorytextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vehiclegatergorytextBox3.Location = new System.Drawing.Point(170, 34);
            this.vehiclegatergorytextBox3.Name = "vehiclegatergorytextBox3";
            this.vehiclegatergorytextBox3.ReadOnly = true;
            this.vehiclegatergorytextBox3.Size = new System.Drawing.Size(155, 23);
            this.vehiclegatergorytextBox3.TabIndex = 3;
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.Controls.Add(this.labelPayID);
            this.paymentGroupBox.Controls.Add(this.paymentIDtextBox6);
            this.paymentGroupBox.Controls.Add(this.labelAmount);
            this.paymentGroupBox.Controls.Add(this.amounttextBox5);
            this.paymentGroupBox.Controls.Add(this.labelMethod);
            this.paymentGroupBox.Controls.Add(this.methodtextBox4);
            this.paymentGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.paymentGroupBox.Location = new System.Drawing.Point(723, 238);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(349, 95);
            this.paymentGroupBox.TabIndex = 10;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "Payment Details";
            // 
            // labelPayID
            // 
            this.labelPayID.AutoSize = true;
            this.labelPayID.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelPayID.Location = new System.Drawing.Point(10, 18);
            this.labelPayID.Name = "labelPayID";
            this.labelPayID.Size = new System.Drawing.Size(64, 13);
            this.labelPayID.TabIndex = 0;
            this.labelPayID.Text = "Payment ID";
            // 
            // paymentIDtextBox6
            // 
            this.paymentIDtextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.paymentIDtextBox6.Location = new System.Drawing.Point(10, 34);
            this.paymentIDtextBox6.Name = "paymentIDtextBox6";
            this.paymentIDtextBox6.ReadOnly = true;
            this.paymentIDtextBox6.Size = new System.Drawing.Size(95, 23);
            this.paymentIDtextBox6.TabIndex = 1;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelAmount.Location = new System.Drawing.Point(115, 18);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(48, 13);
            this.labelAmount.TabIndex = 2;
            this.labelAmount.Text = "Amount";
            // 
            // amounttextBox5
            // 
            this.amounttextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amounttextBox5.Location = new System.Drawing.Point(115, 34);
            this.amounttextBox5.Name = "amounttextBox5";
            this.amounttextBox5.ReadOnly = true;
            this.amounttextBox5.Size = new System.Drawing.Size(105, 23);
            this.amounttextBox5.TabIndex = 3;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelMethod.Location = new System.Drawing.Point(230, 18);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(48, 13);
            this.labelMethod.TabIndex = 4;
            this.labelMethod.Text = "Method";
            // 
            // methodtextBox4
            // 
            this.methodtextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.methodtextBox4.Location = new System.Drawing.Point(230, 34);
            this.methodtextBox4.Name = "methodtextBox4";
            this.methodtextBox4.ReadOnly = true;
            this.methodtextBox4.Size = new System.Drawing.Size(105, 23);
            this.methodtextBox4.TabIndex = 5;
            // 
            // lessonGroupBox
            // 
            this.lessonGroupBox.Controls.Add(this.dataGridView2);
            this.lessonGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lessonGroupBox.Location = new System.Drawing.Point(12, 341);
            this.lessonGroupBox.Name = "lessonGroupBox";
            this.lessonGroupBox.Size = new System.Drawing.Size(1060, 195);
            this.lessonGroupBox.TabIndex = 11;
            this.lessonGroupBox.TabStop = false;
            this.lessonGroupBox.Text = "Lesson Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(8, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1044, 165);
            this.dataGridView2.TabIndex = 0;
            // 
            // printbutton1
            // 
            this.printbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.printbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbutton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.printbutton1.ForeColor = System.Drawing.Color.White;
            this.printbutton1.Location = new System.Drawing.Point(530, 546);
            this.printbutton1.Name = "printbutton1";
            this.printbutton1.Size = new System.Drawing.Size(120, 35);
            this.printbutton1.TabIndex = 12;
            this.printbutton1.Text = "Print Receipt";
            this.printbutton1.UseVisualStyleBackColor = false;
            this.printbutton1.Click += new System.EventHandler(this.printbutton1_Click);
            // 
            // emailbutton3
            // 
            this.emailbutton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.emailbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailbutton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.emailbutton3.ForeColor = System.Drawing.Color.White;
            this.emailbutton3.Location = new System.Drawing.Point(660, 546);
            this.emailbutton3.Name = "emailbutton3";
            this.emailbutton3.Size = new System.Drawing.Size(120, 35);
            this.emailbutton3.TabIndex = 13;
            this.emailbutton3.Text = "Email Receipt";
            this.emailbutton3.UseVisualStyleBackColor = false;
            this.emailbutton3.Click += new System.EventHandler(this.emailbutton3_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(790, 546);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(90, 35);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Clear";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.Location = new System.Drawing.Point(890, 546);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(90, 35);
            this.backbutton.TabIndex = 15;
            this.backbutton.Text = "Back (Rec)";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.statusLabel.ForeColor = System.Drawing.Color.Gray;
            this.statusLabel.Location = new System.Drawing.Point(12, 556);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 13);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Ready...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(983, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back (Man)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 590);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.emailbutton3);
            this.Controls.Add(this.printbutton1);
            this.Controls.Add(this.lessonGroupBox);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.packageGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ikhwezi Driving School — Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.packageGroupBox.ResumeLayout(false);
            this.packageGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.lessonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox EmailtextBox1;
        private System.Windows.Forms.Label labelNames;
        private System.Windows.Forms.TextBox namestextBox3;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox phonetextBox2;
        private System.Windows.Forms.GroupBox packageGroupBox;
        private System.Windows.Forms.Label labelPackage;
        private System.Windows.Forms.TextBox packagetextBox1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox vehiclegatergorytextBox3;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.Label labelPayID;
        private System.Windows.Forms.TextBox paymentIDtextBox6;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox amounttextBox5;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.TextBox methodtextBox4;
        private System.Windows.Forms.GroupBox lessonGroupBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button printbutton1;
        private System.Windows.Forms.Button emailbutton3;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button1;
    }
}