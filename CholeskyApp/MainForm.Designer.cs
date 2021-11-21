
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
            this.mainControl1 = new CholeskyApp.Controls.MainControl();
            this.pageTwoControl1 = new CholeskyApp.Controls.PageTwoControl();
            this.topMenu.SuspendLayout();
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
            this.topMenu.Size = new System.Drawing.Size(1309, 24);
            this.topMenu.TabIndex = 0;
            this.topMenu.Text = "topMenu";
            this.topMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.topMenu_ItemClicked);
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
            // mainControl1
            // 
            this.mainControl1.Location = new System.Drawing.Point(12, 27);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(1289, 615);
            this.mainControl1.TabIndex = 1;
            // 
            // pageTwoControl1
            // 
            this.pageTwoControl1.Location = new System.Drawing.Point(0, 27);
            this.pageTwoControl1.Name = "pageTwoControl1";
            this.pageTwoControl1.Size = new System.Drawing.Size(1309, 615);
            this.pageTwoControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 654);
            this.Controls.Add(this.mainControl1);
            this.Controls.Add(this.topMenu);
            this.Controls.Add(this.pageTwoControl1);
            this.Name = "MainForm";
            this.Text = "Cholesky LTT Application";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
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
        private Controls.MainControl mainControl1;
        private Controls.PageTwoControl pageTwoControl1;
    }
}