using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Cachette : Objet_Environnement
    {
        protected Objet_Inventaire contenu;
        public Cachette(string nom) : base(nom)
        {
            Random a = new Random(100);
            int alea = a.Next();
            if (alea <= 20)
            {
                contenu = new Clef();
            }
        }

        public virtual void fouiller(Stuff inventaire)
        {
            if (contenu == null)
            {
                Console.WriteLine("Il n'y a rien ici.");
            }
            else
            {
                Console.WriteLine("Il y a quelque chose là-dedans...");
                inventaire.ajouterItem(contenu);
                contenu = null;
            }
        }
    }
}
