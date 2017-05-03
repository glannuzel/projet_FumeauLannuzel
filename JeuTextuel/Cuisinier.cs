using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Cuisinier : Personnel_etablissement
    {
        public Cuisinier() : base()
        {
            Sante = 5;
            Relation = 65;
            Accepter_objet = 75;
            Service = 65;

        }

        public override string ToString()
        {
            return "Bonjour je m'appelle : " + Nom + "\nJe suis cuisinier";
        }
    }
}
