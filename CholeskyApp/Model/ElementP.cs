using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CholeskyApp.Model
{
    public class ElementP
    {
        public int Id { get; set; }
        public int W_I { get; set; }
        public int W_J { get; set; }
        public int W_K { get; set; }

        public string M1 { get; set; }
        public string M2 { get; set; }
        public string M3 { get; set; }
        public string M4 { get; set; }
        public string M5 { get; set; }

        public RodzajOperacji RodzajOperacji { get; set; }

    }
}
