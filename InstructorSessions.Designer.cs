using System;

namespace Driving_school_login_form
{
    partial class InstructorSessions
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNamesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instruEmailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignInstruSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupWst27DataSet2 = new Driving_school_login_form.GroupWst27DataSet2();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.assignInstruSessionTableAdapter = new Driving_school_login_form.GroupWst27DataSet2TableAdapters.AssignInstruSessionTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignInstruSessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst27DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studEmailAddressDataGridViewTextBoxColumn,
            this.lessonIDDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.fullNamesDataGridViewTextBoxColumn,
            this.lessonDateTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.lessonTypeDataGridViewTextBoxColumn,
            this.instruEmailAddressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assignInstruSessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // studEmailAddressDataGridViewTextBoxColumn
            // 
            this.studEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "StudEmailAddress";
            this.studEmailAddressDataGridViewTextBoxColumn.HeaderText = "StudEmailAddress";
            this.studEmailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studEmailAddressDataGridViewTextBoxColumn.Name = "studEmailAddressDataGridViewTextBoxColumn";
            this.studEmailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonIDDataGridViewTextBoxColumn
            // 
            this.lessonIDDataGridViewTextBoxColumn.DataPropertyName = "LessonID";
            this.lessonIDDataGridViewTextBoxColumn.HeaderText = "LessonID";
            this.lessonIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lessonIDDataGridViewTextBoxColumn.Name = "lessonIDDataGridViewTextBoxColumn";
            this.lessonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNamesDataGridViewTextBoxColumn
            // 
            this.fullNamesDataGridViewTextBoxColumn.DataPropertyName = "FullNames";
            this.fullNamesDataGridViewTextBoxColumn.HeaderText = "FullNames";
            this.fullNamesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNamesDataGridViewTextBoxColumn.Name = "fullNamesDataGridViewTextBoxColumn";
            this.fullNamesDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonDateTimeDataGridViewTextBoxColumn
            // 
            this.lessonDateTimeDataGridViewTextBoxColumn.DataPropertyName = "LessonDateTime";
            this.lessonDateTimeDataGridViewTextBoxColumn.HeaderText = "LessonDateTime";
            this.lessonDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lessonDateTimeDataGridViewTextBoxColumn.Name = "lessonDateTimeDataGridViewTextBoxColumn";
            this.lessonDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonTypeDataGridViewTextBoxColumn
            // 
            this.lessonTypeDataGridViewTextBoxColumn.DataPropertyName = "LessonType";
            this.lessonTypeDataGridViewTextBoxColumn.HeaderText = "LessonType";
            this.lessonTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lessonTypeDataGridViewTextBoxColumn.Name = "lessonTypeDataGridViewTextBoxColumn";
            this.lessonTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // instruEmailAddressDataGridViewTextBoxColumn
            // 
            this.instruEmailAddressDataGridViewTextBoxColumn.DataPropertyName = "InstruEmailAddress";
            this.instruEmailAddressDataGridViewTextBoxColumn.HeaderText = "InstruEmailAddress";
            this.instruEmailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instruEmailAddressDataGridViewTextBoxColumn.Name = "instruEmailAddressDataGridViewTextBoxColumn";
            this.instruEmailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignInstruSessionBindingSource
            // 
            this.assignInstruSessionBindingSource.DataMember = "AssignInstruSession";
            this.assignInstruSessionBindingSource.DataSource = this.groupWst27DataSet2;
            // 
            // groupWst27DataSet2
            // 
            this.groupWst27DataSet2.DataSetName = "GroupWst27DataSet2";
            this.groupWst27DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(867, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Instructor Email";
            // 
            // assignInstruSessionTableAdapter
            // 
            this.assignInstruSessionTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InstructorSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InstructorSessions";
            this.Text = "InstructorSessions";
            this.Load += new System.EventHandler(this.InstructorSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignInstruSessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupWst27DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InstructorSessions_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.assignInstruSessionTableAdapter.FillByInstruSearch(
        this.groupWst27DataSet2.AssignInstruSession,
        this.textBox1.Text
            );

           // this.assignInstruSessionTableAdapter.FillByInstruSearch(this.groupWst27DataSet2.AssignInstruSession
            //this.groupWst27DataSet2.AssignInstruSession, this.textBox1.Text);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private GroupWst27DataSet2 groupWst27DataSet2;
        private EventHandler button1_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource assignInstruSessionBindingSource;
        private GroupWst27DataSet2TableAdapters.AssignInstruSessionTableAdapter assignInstruSessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNamesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruEmailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
    }
}