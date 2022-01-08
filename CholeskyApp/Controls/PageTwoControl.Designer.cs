
namespace CholeskyApp.Controls
{
    partial class PageTwoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nr_taktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTaktuFT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFs1 = new System.Windows.Forms.Label();
            this.lblFs2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEPFt = new System.Windows.Forms.Label();
            this.lblTimeFt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.W,
            this.EP,
            this.Latency,
            this.Nr_taktu,
            this.NrTaktuFT});
            this.dataGridView1.Location = new System.Drawing.Point(395, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(479, 825);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // W
            // 
            this.W.HeaderText = "W";
            this.W.MinimumWidth = 6;
            this.W.Name = "W";
            this.W.Width = 75;
            // 
            // EP
            // 
            this.EP.HeaderText = "EP";
            this.EP.MinimumWidth = 6;
            this.EP.Name = "EP";
            this.EP.Width = 75;
            // 
            // Latency
            // 
            this.Latency.HeaderText = "Latency";
            this.Latency.MinimumWidth = 6;
            this.Latency.Name = "Latency";
            this.Latency.Width = 75;
            // 
            // Nr_taktu
            // 
            this.Nr_taktu.HeaderText = "Nr_taktu";
            this.Nr_taktu.MinimumWidth = 6;
            this.Nr_taktu.Name = "Nr_taktu";
            this.Nr_taktu.Width = 75;
            // 
            // NrTaktuFT
            // 
            this.NrTaktuFT.HeaderText = "NrTaktuFT";
            this.NrTaktuFT.MinimumWidth = 6;
            this.NrTaktuFT.Name = "NrTaktuFT";
            this.NrTaktuFT.Width = 75;
            // 
            // lblFs1
            // 
            this.lblFs1.AutoSize = true;
            this.lblFs1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFs1.Location = new System.Drawing.Point(291, 19);
            this.lblFs1.Name = "lblFs1";
            this.lblFs1.Size = new System.Drawing.Size(81, 35);
            this.lblFs1.TabIndex = 3;
            this.lblFs1.Text = "label1";
            // 
            // lblFs2
            // 
            this.lblFs2.AutoSize = true;
            this.lblFs2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFs2.Location = new System.Drawing.Point(291, 54);
            this.lblFs2.Name = "lblFs2";
            this.lblFs2.Size = new System.Drawing.Size(81, 35);
            this.lblFs2.TabIndex = 4;
            this.lblFs2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Średnie obciążenie EP[%]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(240, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "FS:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(288, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(81, 35);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(171, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Czas[ns]:";
            // 
            // lblEP
            // 
            this.lblEP.AutoSize = true;
            this.lblEP.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEP.Location = new System.Drawing.Point(288, 86);
            this.lblEP.Name = "lblEP";
            this.lblEP.Size = new System.Drawing.Size(81, 35);
            this.lblEP.TabIndex = 13;
            this.lblEP.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEP);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 170);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zachłanna metoda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblEPFt);
            this.groupBox2.Controls.Add(this.lblTimeFt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(3, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 170);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ft";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Średnie obciążenie EP[%]:";
            // 
            // lblEPFt
            // 
            this.lblEPFt.AutoSize = true;
            this.lblEPFt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEPFt.Location = new System.Drawing.Point(288, 86);
            this.lblEPFt.Name = "lblEPFt";
            this.lblEPFt.Size = new System.Drawing.Size(81, 35);
            this.lblEPFt.TabIndex = 13;
            this.lblEPFt.Text = "label2";
            // 
            // lblTimeFt
            // 
            this.lblTimeFt.AutoSize = true;
            this.lblTimeFt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeFt.Location = new System.Drawing.Point(288, 31);
            this.lblTimeFt.Name = "lblTimeFt";
            this.lblTimeFt.Size = new System.Drawing.Size(81, 35);
            this.lblTimeFt.TabIndex = 11;
            this.lblTimeFt.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(171, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Czas[ns]:";
            // 
            // PageTwoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFs2);
            this.Controls.Add(this.lblFs1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PageTwoControl";
            this.Size = new System.Drawing.Size(880, 848);
            this.Load += new System.EventHandler(this.PageTwoControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblFs1;
        public System.Windows.Forms.Label lblFs2;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Label lblEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn W;
        private System.Windows.Forms.DataGridViewTextBoxColumn EP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nr_taktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTaktuFT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblEPFt;
        public System.Windows.Forms.Label lblTimeFt;
        private System.Windows.Forms.Label label7;
    }
}
