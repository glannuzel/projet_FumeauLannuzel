using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Cintre : Objet_Inventaire
    {
        public Cintre() : base("cintre") { }

        public override string ToString()
        {
            return ("un cintre");
        }
    }
}
