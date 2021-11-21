
namespace CholeskyApp.Controls
{
    partial class MainControl
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
            this.matrixSizeNumericInput = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.M5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_J = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.W_I = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rodzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultsList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.matrixSizeNumericInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixSizeNumericInput
            // 
            this.matrixSizeNumericInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matrixSizeNumericInput.Location = new System.Drawing.Point(0, 0);
            this.matrixSizeNumericInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.matrixSizeNumericInput.Name = "matrixSizeNumericInput";
            this.matrixSizeNumericInput.Size = new System.Drawing.Size(93, 43);
            this.matrixSizeNumericInput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(96, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // M5
            // 
            this.M5.HeaderText = "M5";
            this.M5.Name = "M5";
            // 
            // M4
            // 
            this.M4.HeaderText = "M4";
            this.M4.Name = "M4";
            // 
            // M3
            // 
            this.M3.HeaderText = "M3";
            this.M3.Name = "M3";
            // 
            // M2
            // 
            this.M2.HeaderText = "M2";
            this.M2.Name = "M2";
            // 
            // M1
            // 
            this.M1.HeaderText = "M1";
            this.M1.Name = "M1";
            // 
            // W_K
            // 
            this.W_K.HeaderText = "W_K";
            this.W_K.Name = "W_K";
            // 
            // W_J
            // 
            this.W_J.HeaderText = "W_J";
            this.W_J.Name = "W_J";
            // 
            // W_I
            // 
            this.W_I.HeaderText = "W_I";
            this.W_I.Name = "W_I";
            // 
            // Rodzaj
            // 
            this.Rodzaj.HeaderText = "Rodzaj";
            this.Rodzaj.Name = "Rodzaj";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
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
            this.dataGridView1.Location = new System.Drawing.Point(251, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 636);
            this.dataGridView1.TabIndex = 6;
            // 
            // resultsList
            // 
            this.resultsList.AllowDrop = true;
            this.resultsList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsList.HideSelection = false;
            this.resultsList.Location = new System.Drawing.Point(0, 49);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(248, 587);
            this.resultsList.TabIndex = 5;
            this.resultsList.UseCompatibleStateImageBehavior = false;
            this.resultsList.View = System.Windows.Forms.View.List;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrixSizeNumericInput);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1295, 636);
            ((System.ComponentModel.ISupportInitialize)(this.matrixSizeNumericInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown matrixSizeNumericInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn M5;
        private System.Windows.Forms.DataGridViewTextBoxColumn M4;
        private System.Windows.Forms.DataGridViewTextBoxColumn M3;
        private System.Windows.Forms.DataGridViewTextBoxColumn M2;
        private System.Windows.Forms.DataGridViewTextBoxColumn M1;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_K;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_J;
        private System.Windows.Forms.DataGridViewTextBoxColumn W_I;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView resultsList;
    }
}
