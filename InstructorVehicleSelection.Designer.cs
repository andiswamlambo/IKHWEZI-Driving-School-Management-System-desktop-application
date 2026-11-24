namespace Driving_school_login_form
{
    partial class InstructorVehicleSelection
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
            this.dataGridInstructor = new System.Windows.Forms.DataGridView();
            this.dataGridVehicle = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstructor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridInstructor
            // 
            this.dataGridInstructor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInstructor.Location = new System.Drawing.Point(39, 59);
            this.dataGridInstructor.Name = "dataGridInstructor";
            this.dataGridInstructor.Size = new System.Drawing.Size(630, 150);
            this.dataGridInstructor.TabIndex = 0;
            this.dataGridInstructor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInstructor_CellContentClick);
            // 
            // dataGridVehicle
            // 
            this.dataGridVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehicle.Location = new System.Drawing.Point(39, 252);
            this.dataGridVehicle.Name = "dataGridVehicle";
            this.dataGridVehicle.Size = new System.Drawing.Size(340, 150);
            this.dataGridVehicle.TabIndex = 1;
            this.dataGridVehicle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVehicle_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Instructor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(39, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Vehicle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available instructors and vehicles at the selected time and date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(594, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InstructorVehicleSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridVehicle);
            this.Controls.Add(this.dataGridInstructor);
            this.Name = "InstructorVehicleSelection";
            this.Text = "Instructor & Vehicle Selection";
            this.Load += new System.EventHandler(this.InstructorVehicleSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInstructor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInstructor;
        private System.Windows.Forms.DataGridView dataGridVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}