using CholeskyApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CholeskyApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void topMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string itemText = e.ClickedItem.Text;
            switch (itemText)
            {
                case "Home":
                    hideControls();
                    showHomePage();
                    break;

                case "Tab2":
                    hideControls();
                    showTab2();
                    break;
                default:
                    break;
            }
        }

        private void hideControls()
        {
            mainControl1.Hide();
            pageTwoControl1.Hide();

        }

        private void showTab2()
        {
            pageTwoControl1.Show();
            pageTwoControl1.BringToFront();
        }

        private void showHomePage()
        {
            mainControl1.Show();
            mainControl1.BringToFront();
        }
    }
}
