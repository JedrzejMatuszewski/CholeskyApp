using CholeskyApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            pageTwoControl1.lblFs1.Text = "{1, 0, 1}";
            pageTwoControl1.lblFs2.Text = "{0, 1, 0}";

            pageTwoControl2.lblFs1.Text = "{-1, 0, -1}";
            pageTwoControl2.lblFs2.Text = "{1, 0, -1}";

            pageTwoControl3.lblFs1.Text = "{0, 0, 1}";
            pageTwoControl3.lblFs2.Text = " ";

        }

        private void pageTwoControl1_Click(object sender, EventArgs e)
        {
            this.pageTwoControl1.ltt = this.mainControl1.ltt;
            mainControl1.CreateTactNumber(new Vector3(1, 0, 1), new Vector3(0, 1, 0));
            pageTwoControl1.LoadData(new Vector3(1, 0, 1), new Vector3(0, 1, 0), mainControl1.lista, 2*mainControl1.size+2);

            mainControl1.CreateTactNumber(new Vector3(-1, 0, -1), new Vector3(1, 0, -1));
            this.pageTwoControl2.ltt = this.mainControl1.ltt;
            pageTwoControl2.LoadData(new Vector3(-1, 0, -1), new Vector3(1, 0, -1), mainControl1.lista, 2*mainControl1.size-1);

            mainControl1.CreateTactNumber(new Vector3(0, 0, 1), new Vector3(0, 0, 0));
            this.pageTwoControl3.ltt = this.mainControl1.ltt;
            pageTwoControl3.LoadData(new Vector3(0, 0, 1), new Vector3(0, 0, 0), mainControl1.lista, mainControl1.size);

            
        }
    }
}
