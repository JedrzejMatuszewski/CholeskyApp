
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
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab3Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Contact = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixSizeNumericInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.resultsList = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_J = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixSizeNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.Tab2,
            this.Tab3Menu,
            this.Contact});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1371, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "topMenu";
            // 
            // Home
            // 
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(52, 20);
            this.Home.Text = "Home";
            this.Home.ToolTipText = "Home";
            // 
            // Tab2
            // 
            this.Tab2.Name = "Tab2";
            this.Tab2.Size = new System.Drawing.Size(43, 20);
            this.Tab2.Text = "Tab2";
            this.Tab2.ToolTipText = "Tab2";
            // 
            // Tab3Menu
            // 
            this.Tab3Menu.Name = "Tab3Menu";
            this.Tab3Menu.Size = new System.Drawing.Size(43, 20);
            this.Tab3Menu.Text = "Tab3";
            this.Tab3Menu.ToolTipText = "Tab3";
            // 
            // Contact
            // 
            this.Contact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Help});
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(61, 20);
            this.Contact.Text = "Contact";
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(99, 22);
            this.Help.Text = "Help";
            // 
            // matrixSizeNumericInput
            // 
            this.matrixSizeNumericInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrixSizeNumericInput.Location = new System.Drawing.Point(12, 27);
            this.matrixSizeNumericInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.matrixSizeNumericInput.Name = "matrixSizeNumericInput";
            this.matrixSizeNumericInput.Size = new System.Drawing.Size(93, 43);
            this.matrixSizeNumericInput.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(111, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultsList
            // 
            this.resultsList.AllowDrop = true;
            this.resultsList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsList.HideSelection = false;
            this.resultsList.Location = new System.Drawing.Point(12, 88);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(236, 350);
            this.resultsList.TabIndex = 1;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.List;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Rodzaj,
            this.W_I,
            this.W_J,
            this.W_K,
            this.M1,
            this.M2,
            this.M3,
            this.M4,
            this.M5});
            this.dataGridView1.Location = new System.Drawing.Point(281, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1078, 707);
            this.dataGridView1.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Rodzaj
            // 
            this.Rodzaj.HeaderText = "Rodzaj";
            this.Rodzaj.Name = "Rodzaj";
            // 
            // W_I
            // 
            this.W_I.HeaderText = "W_I";
            this.W_I.Name = "W_I";
            // 
            // W_J
            // 
            this.W_J.HeaderText = "W_J";
            this.W_J.Name = "W_J";
            // 
            // W_K
            // 
            this.W_K.HeaderText = "W_K";
            this.W_K.Name = "W_K";
            // 
            // M1
            // 
            this.M1.HeaderText = "M1";
            this.M1.Name = "M1";
            // 
            // M2
            // 
            this.M2.HeaderText = "M2";
            this.M2.Name = "M2";
            // 
            // M3
            // 
            this.M3.HeaderText = "M3";
            this.M3.Name = "M3";
            // 
            // M4
            // 
            this.M4.HeaderText = "M4";
            this.M4.Name = "M4";
            // 
            // M5
            // 
            this.M5.HeaderText = "M5";
            this.M5.Name = "M5";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 746);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrixSizeNumericInput);
            this.Controls.Add(this.topMenu);
            this.Name = "MainForm";
            this.Text = "Cholesky LTT Application";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixSizeNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem Tab2;
        private System.Windows.Forms.ToolStripMenuItem Tab3Menu;
        private System.Windows.Forms.ToolStripMenuItem Contact;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.NumericUpDown matrixSizeNumericInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView resultsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_J;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_K;
        private System.Windows.Forms.DataGridViewTextBoxColumn M1;
        private System.Windows.Forms.DataGridViewTextBoxColumn M2;
        private System.Windows.Forms.DataGridViewTextBoxColumn M3;
        private System.Windows.Forms.DataGridViewTextBoxColumn M4;
        private System.Windows.Forms.DataGridViewTextBoxColumn M5;
    }
}