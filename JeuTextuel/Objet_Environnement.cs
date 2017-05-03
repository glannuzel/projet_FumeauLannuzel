using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Objet_Environnement : Objet
    {
        public Objet_Environnement(string nom) : base(nom) { }

        public abstract void interagir(Perso_principal perso, Stuff inventaire);
    }
}
