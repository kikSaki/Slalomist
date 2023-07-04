using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slalomist
{
    public class PametniKolesar : VzvratniKolesar
    {
        public PametniKolesar(int x, int y, Steza steza) : base(x, y, steza) { }

        public (int prevozeno, String pot) nacrt(String pot = "")
        {
            if(this.y.Equals(this.steza.y) ) { return (this.prevozeno(), pot); }

            int x = this.x;
            int y = this.y;
            List<(int prevozeno, String pot)> moznePoti = new List<(int prevozeno, String pot)>();

            this.premik('v');
            if(this.y != y)
            {
                moznePoti.Add(this.nacrt(pot + "v"));
            }
            this.nazaj();

            if (pot.Length == 0 || pot.LastIndexOf('v') == pot.Length - 1)
            {
                this.premik('>');
                if(this.x != x)
                {
                    moznePoti.Add(this.nacrt(pot + ">"));
                }
                this.nazaj();

                this.premik('<');
                if (this.x != x)
                {
                    moznePoti.Add(this.nacrt(pot + "<"));
                }
                this.nazaj();
            }

            if(moznePoti.Count != 0)
            {
                (int prevozeno, String pot) min = moznePoti[0];

                foreach ((int prevozeno, String pot) temp in moznePoti)
                {
                    if (temp.prevozeno < min.prevozeno && temp.prevozeno != 0)
                    {
                        min = temp;
                    }
                }
                return min;
            }

            return (0, "");
        }
    }
}
