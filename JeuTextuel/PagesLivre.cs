using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class PagesLivre : Objet_Inventaire
    {
        public PagesLivre() : base("pages de livre") { }

        public override string ToString()
        {
            return ("des pages d'un livre");
        }
    }
}
