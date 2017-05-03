using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class DebrisMiroir : Objet_Inventaire
    {
        public DebrisMiroir() : base("débris de miroir") { }

        public override string ToString()
        {
            return ("des débris de miroir");
        }
    }
}
