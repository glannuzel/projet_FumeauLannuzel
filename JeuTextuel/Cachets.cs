using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Cachets : Objet_Inventaire
    {
        public Cachets() : base("cachets") { }

        public override string ToString()
        {
            return ("des cachets");
        }
    }
}
