using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class PNJ
    {
        protected static Random randint = new Random();

        protected string[] listeNoms = { "Jean", "Pierre", "Samuel", "Francis", "Jacques", "Jeanne", "Gaëlle", "Julie", "Camille", "Justine" };
        private int relation;
        public int Relation
        {
            get { return relation; }
            set { relation = value; }
        }

        private string etat;
        public string Etat
        {
            get { return etat; }
            set { etat = value; }
        }


        private string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (nom == null)       //Sert à empêcher que l'on renomme le pnj
                {
                    nom = value;
                }

            }
        }

        private double sante;
        public double Sante
        {
            get { return sante; }
            set
            {
                sante = value;
            }
        }

        public void dialogue(int relationJoueur)
        {
            if (relation < relationJoueur)
            {
                Console.WriteLine("Salut poto");
            }
            else
            {
                if ((relationJoueur * 100) / relation > 25)
                {
                    int parler = randint.Next(0, 2);
                    if (parler == 0)
                    {
                        Console.WriteLine("Casse-toi!");
                    }
                    else
                    {
                        Console.WriteLine("Salut poto");
                    }
                }
                if ((relationJoueur * 100) / relation < 25)
                {
                    Console.WriteLine("Casse-toi!");
                }
            }
        }

        public PNJ()
        {
            this.Sante = sante;
            this.Relation = relation;
            Etat = "Eveil";
            int chanceNom = randint.Next(0, 10);
            Nom = listeNoms[chanceNom];
        }
    }
}
