using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Agent_entretien : Personnel_etablissement
    {
        public Agent_entretien() : base()
        {
            Sante = 60;
            Relation = 65;
            Accepter_objet = 55;
            Service = 65;

        }

        public override string ToString()
        {
            return "Bonjour je m'appelle : " + Nom + "\nJe suis Agent d'entretien";
        }
    }
}
