using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slalomist
{
    public class AvtonomniKolesar : Kolesar
    {
        public String nacrt { get; set; }
        private bool dol;
        private int st;

        public AvtonomniKolesar(int x, int y, Steza steza, String nacrt) : base(x, y, steza)
        {
            this.nacrt = nacrt;
            this.dol = true;
            this.st = 0;
        }

        public void premik()
        {
            if (dol) { this.premik('v'); dol = false; }
            else { this.premik(nacrt[st]); st++; dol = true;  }    

            if(st == nacrt.Length - 1) { st = 0; }
        }
    }
}
