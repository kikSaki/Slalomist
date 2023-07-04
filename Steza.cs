using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slalomist
{
    public class Steza
    {

        public int x {  get; set; }
        public int y { get; set; }
        public List<(int y, int x0, int x1)> ovire { get; set; }

        public Steza(int x, int y, List<(int y, int x0, int x1)> ovire)
        {
            this.x = x;
            this.y = y;
            this.ovire = ovire;
        }

        public bool zaprto(int x, int y)
        {
            return this.ovire.Any(z => z.y == y && z.x1 >= x && z.x0 <= x); 
        }

        public (int x, int y) konec(int x, int y, char smer)
        {

            while(!zaprto(x, y) && x <= this.x && x > 0 && y <= this.y && y > 0)
            {
                switch (smer)
                    {
                        case '<':
                            x--;
                            break;
                        case '>':
                            x++;
                            break;
                        case 'v':
                            y++;
                            break;
                        case '^':
                            y--;
                            break;
                    }
            }

            switch (smer)
            {
                case '<':
                    return (x + 1, y);
                case '>':
                    return (x - 1, y);
                case 'v':
                    return (x, y - 1);
                case '^':
                    return (x, y + 1);
            }
            return (x, y);
        }


    }
}
