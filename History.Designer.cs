namespace Driving_school_login_form
{
    partial class History
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.separator1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlCardAll = new System.Windows.Forms.Panel();
            this.lblCountAll = new System.Windows.Forms.Label();
            this.lblTitleAll = new System.Windows.Forms.Label();
            this.pnlCardConfirmed = new System.Windows.Forms.Panel();
            this.lblCountConfirmed = new System.Windows.Forms.Label();
            this.lblTitleConfirmed = new System.Windows.Forms.Label();
            this.pnlCardPending = new System.Windows.Forms.Panel();
            this.lblCountPending = new System.Windows.Forms.Label();
            this.lblTitlePending = new System.Windows.Forms.Label();
            this.pnlCardCancelled = new System.Windows.Forms.Panel();
            this.lblCountCancelled = new System.Windows.Forms.Label();
            this.lblTitleCancelled = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlCardAll.SuspendLayout();
            this.pnlCardConfirmed.SuspendLayout();
            this.pnlCardPending.SuspendLayout();
            this.pnlCardCancelled.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.labelTitle.Location = new System.Drawing.Point(20, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "BOOKING HISTORY";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.labelSubtitle.Location = new System.Drawing.Point(22, 48);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(200, 15);
            this.labelSubtitle.TabIndex = 1;
            this.labelSubtitle.Text = "View and search all past bookings";
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(20, 68);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(1080, 2);
            this.separator1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(20, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 290);
            this.dataGridView1.TabIndex = 4;
            // 
            // pnlCardAll
            // 
            this.pnlCardAll.BackColor = System.Drawing.Color.FromArgb(240, 243, 247);
            this.pnlCardAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCardAll.Controls.Add(this.lblCountAll);
            this.pnlCardAll.Controls.Add(this.lblTitleAll);
            this.pnlCardAll.Location = new System.Drawing.Point(20, 112);
            this.pnlCardAll.Name = "pnlCardAll";
            this.pnlCardAll.Size = new System.Drawing.Size(120, 52);
            this.pnlCardAll.TabIndex = 5;
            // 
            // lblCountAll
            // 
            this.lblCountAll.AutoSize = true;
            this.lblCountAll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCountAll.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblCountAll.Location = new System.Drawing.Point(10, 2);
            this.lblCountAll.Name = "lblCountAll";
            this.lblCountAll.Size = new System.Drawing.Size(24, 25);
            this.lblCountAll.TabIndex = 1;
            this.lblCountAll.Text = "0";
            // 
            // lblTitleAll
            // 
            this.lblTitleAll.AutoSize = true;
            this.lblTitleAll.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTitleAll.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleAll.Location = new System.Drawing.Point(10, 30);
            this.lblTitleAll.Name = "lblTitleAll";
            this.lblTitleAll.Size = new System.Drawing.Size(61, 13);
            this.lblTitleAll.TabIndex = 0;
            this.lblTitleAll.Text = "All Bookings";
            // 
            // pnlCardConfirmed
            // 
            this.pnlCardConfirmed.BackColor = System.Drawing.Color.FromArgb(212, 239, 223);
            this.pnlCardConfirmed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCardConfirmed.Controls.Add(this.lblCountConfirmed);
            this.pnlCardConfirmed.Controls.Add(this.lblTitleConfirmed);
            this.pnlCardConfirmed.Location = new System.Drawing.Point(150, 112);
            this.pnlCardConfirmed.Name = "pnlCardConfirmed";
            this.pnlCardConfirmed.Size = new System.Drawing.Size(120, 52);
            this.pnlCardConfirmed.TabIndex = 6;
            // 
            // lblCountConfirmed
            // 
            this.lblCountConfirmed.AutoSize = true;
            this.lblCountConfirmed.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCountConfirmed.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.lblCountConfirmed.Location = new System.Drawing.Point(10, 2);
            this.lblCountConfirmed.Name = "lblCountConfirmed";
            this.lblCountConfirmed.Size = new System.Drawing.Size(24, 25);
            this.lblCountConfirmed.TabIndex = 1;
            this.lblCountConfirmed.Text = "0";
            // 
            // lblTitleConfirmed
            // 
            this.lblTitleConfirmed.AutoSize = true;
            this.lblTitleConfirmed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTitleConfirmed.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleConfirmed.Location = new System.Drawing.Point(10, 30);
            this.lblTitleConfirmed.Name = "lblTitleConfirmed";
            this.lblTitleConfirmed.Size = new System.Drawing.Size(56, 13);
            this.lblTitleConfirmed.TabIndex = 0;
            this.lblTitleConfirmed.Text = "Confirmed";
            // 
            // pnlCardPending
            // 
            this.pnlCardPending.BackColor = System.Drawing.Color.FromArgb(253, 235, 208);
            this.pnlCardPending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCardPending.Controls.Add(this.lblCountPending);
            this.pnlCardPending.Controls.Add(this.lblTitlePending);
            this.pnlCardPending.Location = new System.Drawing.Point(280, 112);
            this.pnlCardPending.Name = "pnlCardPending";
            this.pnlCardPending.Size = new System.Drawing.Size(120, 52);
            this.pnlCardPending.TabIndex = 7;
            // 
            // lblCountPending
            // // 
            this.lblCountPending.AutoSize = true;
            this.lblCountPending.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCountPending.ForeColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.lblCountPending.Location = new System.Drawing.Point(10, 2);
            this.lblCountPending.Name = "lblCountPending";
            this.lblCountPending.Size = new System.Drawing.Size(24, 25);
            this.lblCountPending.TabIndex = 1;
            this.lblCountPending.Text = "0";
            // 
            // lblTitlePending
            // 
            this.lblTitlePending.AutoSize = true;
            this.lblTitlePending.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTitlePending.ForeColor = System.Drawing.Color.Gray;
            this.lblTitlePending.Location = new System.Drawing.Point(10, 30);
            this.lblTitlePending.Name = "lblTitlePending";
            this.lblTitlePending.Size = new System.Drawing.Size(47, 13);
            this.lblTitlePending.TabIndex = 0;
            this.lblTitlePending.Text = "Pending";
            // 
            // pnlCardCancelled
            // 
            this.pnlCardCancelled.BackColor = System.Drawing.Color.FromArgb(250, 219, 216);
            this.pnlCardCancelled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCardCancelled.Controls.Add(this.lblCountCancelled);
            this.pnlCardCancelled.Controls.Add(this.lblTitleCancelled);
            this.pnlCardCancelled.Location = new System.Drawing.Point(410, 112);
            this.pnlCardCancelled.Name = "pnlCardCancelled";
            this.pnlCardCancelled.Size = new System.Drawing.Size(120, 52);
            this.pnlCardCancelled.TabIndex = 8;
            // 
            // lblCountCancelled
            // 
            this.lblCountCancelled.AutoSize = true;
            this.lblCountCancelled.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCountCancelled.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblCountCancelled.Location = new System.Drawing.Point(10, 2);
            this.lblCountCancelled.Name = "lblCountCancelled";
            this.lblCountCancelled.Size = new System.Drawing.Size(24, 25);
            this.lblCountCancelled.TabIndex = 1;
            this.lblCountCancelled.Text = "0";
            // 
            // lblTitleCancelled
            // 
            this.lblTitleCancelled.AutoSize = true;
            this.lblTitleCancelled.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTitleCancelled.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleCancelled.Location = new System.Drawing.Point(10, 30);
            this.lblTitleCancelled.Name = "lblTitleCancelled";
            this.lblTitleCancelled.Size = new System.Drawing.Size(57, 13);
            this.lblTitleCancelled.TabIndex = 0;
            this.lblTitleCancelled.Text = "Cancelled";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblResults.ForeColor = System.Drawing.Color.Gray;
            this.lblResults.Location = new System.Drawing.Point(540, 128);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(80, 13);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "0 bookings found";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(20, 460);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(90, 30);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.Location = new System.Drawing.Point(990, 460);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(90, 30);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(20, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 280);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Records";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1112, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.pnlCardCancelled);
            this.Controls.Add(this.pnlCardPending);
            this.Controls.Add(this.pnlCardConfirmed);
            this.Controls.Add(this.pnlCardAll);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking History - Ikhwezi Driving School";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlCardAll.ResumeLayout(false);
            this.pnlCardAll.PerformLayout();
            this.pnlCardConfirmed.ResumeLayout(false);
            this.pnlCardConfirmed.PerformLayout();
            this.pnlCardPending.ResumeLayout(false);
            this.pnlCardPending.PerformLayout();
            this.pnlCardCancelled.ResumeLayout(false);
            this.pnlCardCancelled.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlCardAll;
        private System.Windows.Forms.Label lblCountAll;
        private System.Windows.Forms.Label lblTitleAll;
        private System.Windows.Forms.Panel pnlCardConfirmed;
        private System.Windows.Forms.Label lblCountConfirmed;
        private System.Windows.Forms.Label lblTitleConfirmed;
        private System.Windows.Forms.Panel pnlCardPending;
        private System.Windows.Forms.Label lblCountPending;
        private System.Windows.Forms.Label lblTitlePending;
        private System.Windows.Forms.Panel pnlCardCancelled;
        private System.Windows.Forms.Label lblCountCancelled;
        private System.Windows.Forms.Label lblTitleCancelled;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}