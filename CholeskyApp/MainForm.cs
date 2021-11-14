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

            this.dataGridView1.Rows.Clear();
            ltt.ListaPomocnicza = ltt.ListaPomocnicza.OrderBy(x => x.W_I).ThenBy(y => y.W_J).ThenBy(z => z.W_K).ToList();

            foreach (var item in ltt.ListaPomocnicza)
            {
                this.dataGridView1.Rows.Add(

                    $"{item.Id}", $"{item.RodzajOperacji}", $"{item.W_I}", $"{item.W_J}", $"{item.W_K}", $"{item.M1}", $"{item.M2}", $"{item.M3}", $"{item.M4}", $"{item.M5}"



                    );
            }

        }

    }
}
