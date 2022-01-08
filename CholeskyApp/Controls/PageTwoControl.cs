using CholeskyApp.Helpers;
using CholeskyApp.Model;
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

namespace CholeskyApp.Controls
{
    public partial class PageTwoControl : UserControl
    {
        public LTTHelper ltt { get; set; }
        public PageTwoControl()
        {
            InitializeComponent();
        }

        private void PageTwoControl_Load(object sender, EventArgs e)
        {
           
        }
        public void LoadData(Vector3 vec1, Vector3 vec2, Dictionary<string,int> lista, int size)
        {
            this.dataGridView1.Rows.Clear();
            ltt.ListaPomocnicza = ltt.ListaPomocnicza.OrderBy(x => x.W_I).ThenBy(y => y.W_J).ThenBy(z => z.W_K).ToList();
            FSHelper fsh = new FSHelper(vec1, vec2);
            fsh.AddData(ltt, lista);
            foreach (var item in fsh.ListaMacierz1)
            {
                this.dataGridView1.Rows.Add(
                    $"{item.Id}", $"{item.W}",
                    $"{item.EP1}"+" "+$"{item.EP2}", $"{item.Latency}", $"{item.NrTaktu}", $"{item.NrTaktuFT}"
                    );
            }
            lblTime.Text = fsh.CalcTime(size).ToString();
            lblEP.Text = fsh.CalcAvgEP().ToString();
            lblTimeFt.Text = fsh.CalcTimeFT(size).ToString();
            lblEPFt.Text = fsh.CalcAvgEPFT().ToString();

        }
        
    }
}
