using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Bouche_aeration : Cachette
    {
        public Bouche_aeration() : base("bouche d\'aération") { }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("Regardons ce qu'il y a dans cette bouche d\'aération.");
            fouiller(inventaire);
        }
    }
}
