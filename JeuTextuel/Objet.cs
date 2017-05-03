using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Objet
    {
        public string nom;
        public Objet(string nom)
        {
            this.nom = nom;
        }
    }
}
