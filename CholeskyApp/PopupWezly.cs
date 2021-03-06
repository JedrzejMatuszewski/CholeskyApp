using CholeskyApp.Model;
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
    public partial class PopupWezly : Form
    {
        public List<Wezel> ListaWezlow { get; set; }

        public PopupWezly()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ListaWezlow)
            {
                dataGridView1.Rows.Add(
                    $"{item.Id}", $"{item.Vector}"
                    );
            }
        }


    }
}
