using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Table_chevet : Cachette
    {
        public Table_chevet() : base("table de chevet") { }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("Il y a peut-être quelque chose dans cette table de chevet. Je vais jeter un oeil");
            fouiller(inventaire);
        }
    }
}
