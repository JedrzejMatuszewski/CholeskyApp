using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CholeskyApp.Model
{
    public class MacierzFS
    {
        public int Id { get; set; }
        public int EP1 { get; set; }
        public int EP2 { get; set; }
        public string W { get; set; }
        public int Latency { get; set; }
        public int NrTaktu { get; set; }
        public int NrTaktuFT { get; set; }
    }
}
