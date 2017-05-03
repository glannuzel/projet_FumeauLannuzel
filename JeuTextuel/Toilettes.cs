using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Toilettes : Objet_Environnement
    {
        private Objet_Inventaire contenu;
        public Toilettes() : base("toilettes")
        {
            Random a = new Random(100);
            int alea = a.Next();
            if (alea <= 20)
            {
                contenu = new Clef();
            }
        }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("1 : Aller aux toilettes");
            Console.WriteLine("2 : Jeter un objet");
            Console.WriteLine("3 : Regarder dans le réservoir");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                allerAuxToilettes(perso);
            }
            if (action == 2)
            {

            }
            if (action == 3)
            {
                regarderReservoir(inventaire);
            }
        }

        public void allerAuxToilettes(Perso_principal perso)
        {
            perso.Sante = perso.Sante + 2;
        }

        public void regarderReservoir(Stuff inventaire)
        {
            if (contenu == null)
            {
                Console.WriteLine("Il n'y a rien dans ce réservoir.");
            }
            else
            {
                Console.WriteLine("Il y a quelque chose là-dedans...");
                inventaire.ajouterItem(contenu);
                contenu = null;
            }
        }

        public override string ToString()
        {
            return ("des toilettes");
        }

    }
}
