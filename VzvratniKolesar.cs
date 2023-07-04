using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slalomist
{
    public class VzvratniKolesar : Kolesar
    {
        public List<(int x, int y)> potPoz {get; set;}
        public List<int> potPrevozeno { get; set; }

        public VzvratniKolesar(int x, int y, Steza steza) : base(x, y, steza)
        {
            potPoz = new List<(int x, int y)> { base.pozicija() };
            potPrevozeno = new List<int> { base.prevozeno() };
        }

        public void premik(char smer)
        {
            base.premik(smer);
            this.potPoz.Add(base.pozicija());
            this.potPrevozeno.Add(base.prevozeno());
        }

        public void nazaj()
        {
            if(potPoz.Count > 1)
            {
                this.potPoz.RemoveAt(this.potPoz.Count - 1);
                this.potPrevozeno.RemoveAt(this.potPrevozeno.Count - 1);
            }

            base.x = this.potPoz[potPoz.Count - 1].x;
            base.y = this.potPoz[potPoz.Count - 1].y;
            base.__prevozeno = this.potPrevozeno[potPrevozeno.Count - 1];
        }
    }
}
