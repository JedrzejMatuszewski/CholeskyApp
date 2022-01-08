
namespace CholeskyApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainControl1 = new CholeskyApp.Controls.MainControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pageTwoControl1 = new CholeskyApp.Controls.PageTwoControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pageTwoControl2 = new CholeskyApp.Controls.PageTwoControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pageTwoControl3 = new CholeskyApp.Controls.PageTwoControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainControl1
            // 
            this.mainControl1.graph = null;
            this.mainControl1.lista = null;
            this.mainControl1.listaLukow = null;
            this.mainControl1.listaWezlow = null;
            this.mainControl1.Location = new System.Drawing.Point(0, 5);
            this.mainControl1.ltt = null;
            this.mainControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(1000, 833);
            this.mainControl1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1498, 969);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1490, 936);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.pageTwoControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1490, 936);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FS 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pageTwoControl1
            // 
            this.pageTwoControl1.Location = new System.Drawing.Point(0, 0);
            this.pageTwoControl1.ltt = null;
            this.pageTwoControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageTwoControl1.Name = "pageTwoControl1";
            this.pageTwoControl1.Size = new System.Drawing.Size(1279, 1060);
            this.pageTwoControl1.TabIndex = 0;
            this.pageTwoControl1.Click += new System.EventHandler(this.pageTwoControl1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.pageTwoControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1490, 936);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FS 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pageTwoControl2
            // 
            this.pageTwoControl2.Location = new System.Drawing.Point(-3, 7);
            this.pageTwoControl2.ltt = null;
            this.pageTwoControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageTwoControl2.Name = "pageTwoControl2";
            this.pageTwoControl2.Size = new System.Drawing.Size(1872, 1060);
            this.pageTwoControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Controls.Add(this.pageTwoControl3);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1490, 936);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "FS 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pageTwoControl3
            // 
            this.pageTwoControl3.Location = new System.Drawing.Point(-4, 0);
            this.pageTwoControl3.ltt = null;
            this.pageTwoControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageTwoControl3.Name = "pageTwoControl3";
            this.pageTwoControl3.Size = new System.Drawing.Size(1872, 1060);
            this.pageTwoControl3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(892, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 678);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(892, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Graf macierzy dla N=4";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(909, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 394);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(909, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Graf macierzy dla N=4";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(924, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 429);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(924, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Graf macierzy dla N=4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 902);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Cholesky LTT Application";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MainControl mainControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Controls.PageTwoControl pageTwoControl1;
        private Controls.PageTwoControl pageTwoControl2;
        private Controls.PageTwoControl pageTwoControl3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}