using CholeskyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CholeskyApp.Helpers
{
    internal class FSHelper
    {
        public List<MacierzFS> ListaMacierz1 { get; set; } 
        public Vector3 vector1 { get; set; }
        public Vector3 vector2 { get; set; }

        private int takty;
        public FSHelper(Vector3 v3, Vector3 v33)
        {
            this.vector1 = v3;
            this.vector2 = v33;
        }
        public void AddData(LTTHelper ltt, Dictionary<string, int > lista)
        {
            ListaMacierz1 = new List<MacierzFS>();
            foreach (var item in ltt.ListaPomocnicza)
            {

                ListaMacierz1.Add(new MacierzFS
                {
                    Id = item.Id,
                    W = item.W_I + " " + item.W_J + " " + item.W_K,
                    EP1 = (int)vector1.X * item.W_I + (int)vector1.Y * item.W_J + (int)vector1.Z * item.W_K,
                    EP2 = (int)vector2.X * item.W_I + (int)vector2.Y * item.W_J + (int)vector2.Z * item.W_K,
                    Latency = 24,
                    NrTaktu = lista[item.W_I + " " + item.W_J + " " + item.W_K],
                    NrTaktuFT = 2*item.W_I + 2*item.W_J + item.W_K
                }); ;
            }
            
        }
        public float CalcTime(int MPPath)
        {
            var query = from a in ListaMacierz1 select a.NrTaktu;
            query.ToList();
            takty = query.Max() - query.Min() + 1;
            float czas = 1000*(takty+ListaMacierz1[0].Latency*MPPath)/350;
            return czas;
        }
        public float CalcTimeFT(int MPPath)
        {
            var query = from a in ListaMacierz1 select a.NrTaktuFT;
            query.ToList();
            takty = query.Max() - query.Min() + 1;
            float czas = 1000 * (takty + ListaMacierz1[0].Latency * MPPath) / 350;
            return czas;
        }
        public float CalcAvgEP()
        {
            var query = from a in ListaMacierz1 select a.EP1+""+a.EP2;
            query = query.Distinct();
            int lw = ListaMacierz1.Count();
            int lep = query.Count();
            float avg = (lw * 100 / (takty*lep)) ;
            return avg;
        }
        public float CalcAvgEPFT()
        {
            var query = from a in ListaMacierz1 select a.EP1 + "" + a.EP2;
            query = query.Distinct();
            int lw = ListaMacierz1.Count();
            int lep = query.Count();
            float avg = (lw * 100 / (takty * lep));
            return avg;
        }
    }
}
