namespace Driving_school_login_form
{
    partial class ManageInstructors
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.specialtextBox2 = new System.Windows.Forms.ComboBox();
            this.licencetextBox3 = new System.Windows.Forms.ComboBox();
            this.experiencetextBox4 = new System.Windows.Forms.TextBox();
            this.AddresstextBox5 = new System.Windows.Forms.TextBox();
            this.phonetextBox6 = new System.Windows.Forms.TextBox();
            this.surnametextBox7 = new System.Windows.Forms.TextBox();
            this.nametextBox8 = new System.Windows.Forms.TextBox();
            this.emailtextBox1 = new System.Windows.Forms.TextBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpInput.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(960, 60);
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
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(228, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Add, update or remove driving instructors";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(216, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Manage Instructors";
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.btnBack);
            this.pnlBody.Controls.Add(this.btnDelete);
            this.pnlBody.Controls.Add(this.btnUpdate);
            this.pnlBody.Controls.Add(this.btnAdd);
            this.pnlBody.Controls.Add(this.btnNew);
            this.pnlBody.Controls.Add(this.grpGrid);
            this.pnlBody.Controls.Add(this.grpInput);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(960, 460);
            this.pnlBody.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(835, 360);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(375, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(255, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(135, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Instructor";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(15, 360);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New / Clear";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.lblCount);
            this.grpGrid.Controls.Add(this.dataGridView1);
            this.grpGrid.Controls.Add(this.searchTextBox);
            this.grpGrid.Controls.Add(this.lblSearch);
            this.grpGrid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpGrid.Location = new System.Drawing.Point(330, 10);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(615, 340);
            this.grpGrid.TabIndex = 1;
            this.grpGrid.TabStop = false;
            this.grpGrid.Text = "Instructor List";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCount.ForeColor = System.Drawing.Color.Gray;
            this.lblCount.Location = new System.Drawing.Point(10, 315);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(71, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0 instructors";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 245);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchTextBox.Location = new System.Drawing.Point(10, 34);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(590, 25);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Location = new System.Drawing.Point(10, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblMode);
            this.grpInput.Controls.Add(this.specialtextBox2);
            this.grpInput.Controls.Add(this.licencetextBox3);
            this.grpInput.Controls.Add(this.experiencetextBox4);
            this.grpInput.Controls.Add(this.AddresstextBox5);
            this.grpInput.Controls.Add(this.phonetextBox6);
            this.grpInput.Controls.Add(this.surnametextBox7);
            this.grpInput.Controls.Add(this.nametextBox8);
            this.grpInput.Controls.Add(this.emailtextBox1);
            this.grpInput.Controls.Add(this.lblSpecialization);
            this.grpInput.Controls.Add(this.lblLicence);
            this.grpInput.Controls.Add(this.lblExperience);
            this.grpInput.Controls.Add(this.lblAddress);
            this.grpInput.Controls.Add(this.lblPhone);
            this.grpInput.Controls.Add(this.lblSurname);
            this.grpInput.Controls.Add(this.lblName);
            this.grpInput.Controls.Add(this.lblEmail);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.grpInput.Location = new System.Drawing.Point(15, 10);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(300, 340);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Instructor Details";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMode.Location = new System.Drawing.Point(10, 18);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(124, 13);
            this.lblMode.TabIndex = 20;
            this.lblMode.Text = "Adding New Instructor";
            // 
            // specialtextBox2
            // 
            this.specialtextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.specialtextBox2.FormattingEnabled = true;
            this.specialtextBox2.Items.AddRange(new object[] {
            "Parking",
            "Road Driving",
            "Highway Driving",
            "Night Driving",
            "Yard Practice",
            "Defensive Driving",
            "Advanced Driving"});
            this.specialtextBox2.Location = new System.Drawing.Point(10, 266);
            this.specialtextBox2.Name = "specialtextBox2";
            this.specialtextBox2.Size = new System.Drawing.Size(275, 23);
            this.specialtextBox2.TabIndex = 8;
            // 
            // licencetextBox3
            // 
            this.licencetextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.licencetextBox3.FormattingEnabled = true;
            this.licencetextBox3.Items.AddRange(new object[] {
            "Code 8",
            "Code 10",
            "Code 14"});
            this.licencetextBox3.Location = new System.Drawing.Point(100, 222);
            this.licencetextBox3.Name = "licencetextBox3";
            this.licencetextBox3.Size = new System.Drawing.Size(95, 23);
            this.licencetextBox3.TabIndex = 7;
            // 
            // experiencetextBox4
            // 
            this.experiencetextBox4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.experiencetextBox4.Location = new System.Drawing.Point(10, 222);
            this.experiencetextBox4.Name = "experiencetextBox4";
            this.experiencetextBox4.Size = new System.Drawing.Size(80, 23);
            this.experiencetextBox4.TabIndex = 6;
            // 
            // AddresstextBox5
            // 
            this.AddresstextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddresstextBox5.Location = new System.Drawing.Point(10, 179);
            this.AddresstextBox5.Name = "AddresstextBox5";
            this.AddresstextBox5.Size = new System.Drawing.Size(275, 23);
            this.AddresstextBox5.TabIndex = 5;
            // 
            // phonetextBox6
            // 
            this.phonetextBox6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phonetextBox6.Location = new System.Drawing.Point(10, 136);
            this.phonetextBox6.MaxLength = 10;
            this.phonetextBox6.Name = "phonetextBox6";
            this.phonetextBox6.Size = new System.Drawing.Size(275, 23);
            this.phonetextBox6.TabIndex = 4;
            // 
            // surnametextBox7
            // 
            this.surnametextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surnametextBox7.Location = new System.Drawing.Point(150, 93);
            this.surnametextBox7.Name = "surnametextBox7";
            this.surnametextBox7.Size = new System.Drawing.Size(135, 23);
            this.surnametextBox7.TabIndex = 3;
            // 
            // nametextBox8
            // 
            this.nametextBox8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nametextBox8.Location = new System.Drawing.Point(10, 93);
            this.nametextBox8.Name = "nametextBox8";
            this.nametextBox8.Size = new System.Drawing.Size(130, 23);
            this.nametextBox8.TabIndex = 2;
            // 
            // emailtextBox1
            // 
            this.emailtextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtextBox1.Location = new System.Drawing.Point(10, 50);
            this.emailtextBox1.Name = "emailtextBox1";
            this.emailtextBox1.Size = new System.Drawing.Size(275, 23);
            this.emailtextBox1.TabIndex = 1;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSpecialization.ForeColor = System.Drawing.Color.Gray;
            this.lblSpecialization.Location = new System.Drawing.Point(10, 250);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(78, 13);
            this.lblSpecialization.TabIndex = 8;
            this.lblSpecialization.Text = "Specialization";
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLicence.ForeColor = System.Drawing.Color.Gray;
            this.lblLicence.Location = new System.Drawing.Point(100, 207);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(69, 13);
            this.lblLicence.TabIndex = 7;
            this.lblLicence.Text = "Licence Type";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblExperience.ForeColor = System.Drawing.Color.Gray;
            this.lblExperience.Location = new System.Drawing.Point(10, 207);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(84, 13);
            this.lblExperience.TabIndex = 6;
            this.lblExperience.Text = "Experience (Yrs)";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAddress.ForeColor = System.Drawing.Color.Gray;
            this.lblAddress.Location = new System.Drawing.Point(10, 164);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPhone.ForeColor = System.Drawing.Color.Gray;
            this.lblPhone.Location = new System.Drawing.Point(10, 121);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblSurname.Location = new System.Drawing.Point(150, 78);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(10, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(10, 35);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Address";
            // 
            // ManageInstructors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManageInstructors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Instructors - Ikhwezi Driving School";
            this.Load += new System.EventHandler(this.ManageInstructors_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.grpGrid.ResumeLayout(false);
            this.grpGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox emailtextBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox nametextBox8;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox surnametextBox7;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox phonetextBox6;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox AddresstextBox5;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox experiencetextBox4;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.ComboBox licencetextBox3;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.ComboBox specialtextBox2;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}