using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Gardien : Personnel_etablissement
    {
        private int draguer;
        public int Draguer
        {
            get { return draguer; }
            set { draguer = value; }
        }

        private int force;
        public int Force
        {
            get { return force; }
            set { force = value; }
        }


        public void drague(int sex_appeal)
        {
            if (Draguer < sex_appeal)
            {
                Console.WriteLine("Drague réussie!");
            }
            if (((sex_appeal * 100) / Draguer) > 25)
            {
                int chanceDrague = randint.Next(0, 2);
                if (chanceDrague == 0)
                {
                    Console.WriteLine("Arrêtez je vous prie");
                }
                else
                {
                    Console.WriteLine("Drague réussie");

                }
            }
            if (((sex_appeal * 100) / Draguer) < 25)
            {
                Console.WriteLine("Arrêtez je vous prie");
            }
        }

        public void attaquer(Perso_principal pp)
        {
            Console.WriteLine("Attaquer avec quoi?" + "\n" + pp.monStuf);
            int index = int.Parse(Console.ReadLine());
            int attaque = pp.Force + (pp.monStuf.elements[index - 1].stat_obj);
            int stop= 1;
            while (Sante > 0||stop==0)
            {
                Console.WriteLine("1) Attaquer\n2) Fuire?");
                int choix = int.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    if (attaque > Force)
                    {
                        Console.WriteLine("Attaque réussie, il pert : " + (0.8 * attaque) + " points de vie");
                        Sante = Sante - (0.8 * attaque);
                    }
                    else
                    {
                        if ((attaque * 100) / Force > 25)
                        {
                            int chanceVictoire = randint.Next(0, 2);
                            if (chanceVictoire == 0)
                            {
                                Console.WriteLine("Attaque réussie, il pert : " + (0.8 * attaque)+ " points de vie");
                                Sante = Sante - (0.8 * attaque);
                            }
                            else
                            {
                                Console.WriteLine("Echec de l'attaque tu perds 10pts de vie"+"\n"+pp);
                                pp.Sante = -10;
                            }
                        }
                        if ((attaque * 100) / Force < 25)
                        {
                            Console.WriteLine("Echec de l'attaque tu perds 10pts de vie"+"\n"+pp);
                            pp.Sante = -10;
                        }
                    }
                    if(Sante<=0)
                    {
                        Console.WriteLine("Il est KO");
                    }
                }
                else
                {
                    stop = 0;
                }
            }
        }

        public Gardien() : base()
        {
            Sante = 80;
            Relation = 85;
            Accepter_objet = 85;
            Service = 95;
            Force = 95;

        }

        public override string ToString()
        {
            return "Bonjour je m'appelle : " + Nom + "\nJe suis gardien";
        }
    }
}
