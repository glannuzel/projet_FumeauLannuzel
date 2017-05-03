using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Objet_Inventaire : Objet
    {
        public Objet_Inventaire(string nom) : base(nom) { }

        public void prendre(Stuff inventaire)
        {
            inventaire.ajouterItem(this);
        }
        public void retirerEnvironnement(Salle salle)
        {
            
        }
    }
}
