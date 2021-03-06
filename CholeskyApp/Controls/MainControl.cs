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
    public partial class MainControl : UserControl
    {
        public LTTHelper ltt { get; set; }
        public List<Luk> listaLukow { get; set; }

        public List<Wezel> listaWezlow { get; set; }

        public Dictionary<string, int> lista { get; set; }
        public PopupForm popup { get; set; }

        public PopupWezly popup2 { get; set; }
        public GraphForm graph { get; set; }

        public int size { get; set; }

        public MainControl()
        {
            InitializeComponent();
            popup = new PopupForm();
            popup2 = new PopupWezly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            size = (int)this.matrixSizeNumericInput.Value;
           
            
            ltt = new LTTHelper(size);
            
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





            listaLukow = new List<Luk>();

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
            
            popup.Dispose();
            popup = new PopupForm();
            popup.ListaLukow = listaLukow.ToList();
            popup.LoadData();
            popup.Show();
            
            listaWezlow = lista.Select(x =>
                new Wezel
                {
                    Id = x.Id,
                    Vector = $"{x.W_I} {x.W_J} {x.W_K}"
                }
            ).ToList();
            
            popup2.Dispose();
            popup2 = new PopupWezly();
            popup2.ListaWezlow = listaWezlow;
            popup2.LoadData();
            popup2.Show();
            
            
            graph = new GraphForm();
            graph.Show();
            
        }


        public void CreateTactNumber(Vector3 v1, Vector3 v2)
        {
            var wezlyPomocnicze = listaWezlow.ToList();
            Dictionary<string, int> listaEP = new Dictionary<string, int>();
            foreach(var item in ltt.ListaPomocnicza)
            {
                listaEP.Add(item.W_I+" "+item.W_J+" "+item.W_K, (int)((item.W_I*v1.X+ item.W_J * v1.Y + item.W_K * v1.Z)*10+(item.W_I * v2.X + item.W_J * v2.Y + item.W_K * v2.Z)));
            }
            lista = new Dictionary<string,int>();
            var listaTymczasowa = new Dictionary<string, int>();
            listaLukow.ToList();
            int i = 1;
            while (wezlyPomocnicze.Count!=0)
            {
                listaTymczasowa.Clear();
                foreach(var item in listaWezlow)
                {
                    //sprawdz czy wezel jest na liscie wychodzacej
                    if (lista.ContainsKey(item.Vector))
                    {

                    }
                    else if (sprawdzWezel(item.Vector))// sprawdz czy wezel jest na liscie lukowo DO
                    {
                        var query = from p in listaLukow where p.Do.Equals(item.Vector) select p.Od;
                        bool dodajDoListy = true;
                        foreach (var items in query)
                        {
                            var querys = from p in lista where p.Key.Equals(items) select p.Value;
                            querys.ToList();
                            int a = querys.Count();
                            if (querys.Count() == 0)
                            {
                                dodajDoListy=false;
                            }
                        }
                        if (dodajDoListy)
                        {
                            //sprawdzenie czy w tym takcie nie wystepuje juz dzialanie z tego EP
                            bool ep = true;
                            foreach(var items in listaTymczasowa)
                            {
                                if(listaEP[items.Key] == listaEP[item.Vector])
                                {
                                    ep = false;
                                }
                            }
                            if (ep)
                            {
                                listaTymczasowa.Add(item.Vector, i);
                                wezlyPomocnicze.Remove(item);
                            }
                            
                        }
                    }
                    else
                    {
                        bool ep = true;
                        foreach (var items in listaTymczasowa)
                        {
                            if (listaEP[items.Key] == listaEP[item.Vector])
                            {
                                ep = false;
                            }
                        }
                        if (ep)
                        {
                            listaTymczasowa.Add(item.Vector, i);
                            wezlyPomocnicze.Remove(item);
                        }
                    }
                }
                foreach(var item in listaTymczasowa)
                {
                    lista.Add(item.Key, item.Value);
                }
                i++;
            }
        }

        public Boolean sprawdzWezel(string item)
        {
            foreach(var item2 in listaLukow)
            {
                if (item2.Do.Equals(item))
                {
                    return true;//jest na liscie lukow do
                }
            }
            return false;
        }



        


    }
}
