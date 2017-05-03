using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    abstract class Patient : PNJ
    {
        private int force;
        public int Force
        {
            get { return force; }
            set { force = value; }
        }

        public void attaquer(Perso_principal pp)
        {
            Console.WriteLine("Attaquer avec quoi?" + "\n" + pp.monStuf);
            int index = int.Parse(Console.ReadLine());
            int attaque = pp.Force + (pp.monStuf.elements[index - 1].stat_obj);
            int stop = 1;
            while (Sante > 0 || stop == 0|| pp.Sante>0)
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
                                Console.WriteLine("Attaque réussie, il pert : " + (0.8 * attaque) + " points de vie");
                                Sante = Sante - (0.8 * attaque);
                            }
                            else
                            {
                                Console.WriteLine("Echec de l'attaque tu perds 10pts de vie" + "\n" + pp);
                                pp.Sante = -10;
                            }
                        }
                        if ((attaque * 100) / Force < 25)
                        {
                            Console.WriteLine("Echec de l'attaque tu perds 10pts de vie" + "\n" + pp);
                            pp.Sante = -10;
                        }
                    }
                    if (Sante <= 0)
                    {
                        Console.WriteLine("Il est KO");
                    }
                    if(pp.Sante<=0)
                    {
                        Console.WriteLine("Vous êtes KO")
                    }
                }
                else
                {
                    stop = 0;
                }
            }
        }

        public Patient() :base()
        {
        }
    }
}
