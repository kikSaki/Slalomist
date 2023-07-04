using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slalomist
{
    public class Kolesar
    {
        public int x {  get; set; }
        public int y { get; set; }
        public Steza steza { get; }
        public int __prevozeno { get; set; }

        public Kolesar(int x, int y, Steza steza) 
        {
            this.x = x;
            this.y = y;
            this.steza = steza;
            this.__prevozeno = 0;
        }

        public (int x, int y) pozicija()
        {
            return (this.x, this.y);
        }

        public void premik(char smer)
        {
            var poz = this.steza.konec(this.x, this.y, smer);

            this.__prevozeno += Math.Abs(this.x - poz.x) + Math.Abs(this.y - poz.y);
            this.x = poz.x; this.y = poz.y;
        }

        public int prevozeno()
        {
            return this.__prevozeno;
        }

        public override string ToString()
        {
            return $"({pozicija().x}, {pozicija().y})";
        }
     }
}
