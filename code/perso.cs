using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class perso
    {
        public int x;
        public int a;
        public perso()
        {
            x = 0;
            a = 0;
        }
        public void deplace(string dir, string sens, string vitesse)
        {
            int v = 0;
            if (vitesse == "r")
            { v = 5; }
            else { v = 1; }
            if (sens == "+")
            {
                if (dir == "h")
                {
                    x += v;

                }
                else
                {
                    a += v;
                }
            }
            else
            {
                if (dir == "h")
                {
                    x -= v;

                }
                else
                {
                    a -= v;
                }
            }

        }
    }
}
