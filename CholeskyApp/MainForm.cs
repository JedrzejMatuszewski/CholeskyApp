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

        private void button1_Click(object sender, EventArgs e)
        {
            var size = (int)this.matrixSizeNumericInput.Value;

            var ltt = new LTTHelper(size);

            this.resultsList.Items.Add($"N: {size} Time: {ltt.GenerationTime} ns");
        }

    }
}
