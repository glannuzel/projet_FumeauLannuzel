using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Confort : Objet_Environnement
    {
        public Confort(string nom) : base(nom) { }

        public abstract void asseoir(Perso_principal perso);
    }
}
