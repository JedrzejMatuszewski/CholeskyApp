using CholeskyApp.Helpers;
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

namespace CholeskyApp.Controls
{
    public partial class MainControl : UserControl
    {
        public MainControl()
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
                    $"{item.Id}", $"{item.RodzajOperacji}", $"{item.W_I}", 
                    $"{item.W_J}", $"{item.W_K}", $"{item.M1}", $"{item.M2}", 
                    $"{item.M3}", $"{item.M4}", $"{item.M5}"
                    );
            }





            var listaLukow = new List<Luk>();

            var forCounter = 1;
            var lokId = 1;

            var lista = ltt.ListaPomocnicza;

            //M1 (6)
            foreach (var item in lista)
            {
                if(item.M1 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M1 == item.M1);
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }

            //M2 --> M3 (7-12)
            forCounter = 1;
            foreach (var item in lista)
            {
                if (item.M2 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M3 == item.M2);
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }

            //M3 13-16
            forCounter = 1;
            foreach (var item in lista)
            {
                if (item.M3 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M3 == item.M3);
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }

            //M4 17-20
            forCounter = 1;
            foreach (var item in lista)
            {
                if (item.M4 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M4 == item.M4);
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }

            //M5 20-24
            forCounter = 1;
            foreach (var item in lista)
            {
                if (item.M5 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M5 == item.M5);
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }


            //M5 --> M2 24-27
            forCounter = 1;
            foreach (var item in lista)
            {
                if (item.M5 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M2 == item.M5 && (x.W_I-item.W_I==1));
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }


            //M5 --> M1 27-30
            forCounter = 1;
            foreach (var item in lista)
            {
                if (item.M5 == null)
                {
                    ++forCounter;
                    continue;
                }

                var next = lista.Skip(forCounter).FirstOrDefault(x => x.M1 == item.M5 && (x.W_I - item.W_I == 1));
                if (next != null)
                {
                    listaLukow.Add(
                        new Luk
                        {
                            Id = lokId,
                            Od = $"{item.W_I} {item.W_J} {item.W_K}",
                            Do = $"{next.W_I} {next.W_J} {next.W_K}"
                        }
                    );
                    ++lokId;
                }
                ++forCounter;
            }



            var result = listaLukow.ToList();

            PopupForm popup = new PopupForm();
            popup.ListaLukow = listaLukow.ToList();
            popup.LoadData();
            popup.Show();

            var listaWezlow = lista.Select(x =>
                new Wezel
                {
                    Id = x.Id,
                    Vector = $"{x.W_I} {x.W_J} {x.W_K}"
                }
            ).ToList();

            var popup2 = new PopupWezly();
            popup2.ListaWezlow = listaWezlow;
            popup2.LoadData();
            popup2.Show();

        }



        


    }
}
