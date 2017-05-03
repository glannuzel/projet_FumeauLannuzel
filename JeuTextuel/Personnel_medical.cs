using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Personnel_medical : PNJ
    {
        private int draguer;
        public int Draguer
        {
            get { return draguer; }
            set { if (draguer == 0) { draguer = value; } }
        }

        private int accepter_objet;
        public int Accepter_objet
        {
            get { return accepter_objet; }
            set { if (accepter_objet == 0) { accepter_objet = value; } }
        }

        public void drague(int sex_appeal)
        {
            if (Draguer < sex_appeal)
            {
                Console.WriteLine("Drague réussie!");
            }
            else
            {
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
        }

        public void donner_Obj(Perso_principal pp)
        {
            if (accepter_objet < pp.Persuasion)
            {
                Console.WriteLine("Quel objet donner ?");
                Console.WriteLine(pp.monStuff);
                int index = int.Parse(Console.ReadLine());
                if (pp.monStuff.voirInventaire()[index] as Cachets != null)
                {
                    Etat = "Sommeil";
                    pp.monStuff.supprimerItem(index - 1);
                    Console.WriteLine("Il s'est endormi");
                }
                else
                {
                    pp.monStuff.supprimerItem(index - 1);
                    Console.WriteLine("Merci infiniment");
                }
            }
            else
            {
                if (((pp.Persuasion * 100) / accepter_objet) > 25)
                {
                    int chanceDont = randint.Next(0, 2);
                    if (chanceDont == 0)
                    {
                        Console.WriteLine("Désolé je ne peux rien n'accepter de la part des patients");
                    }
                    else
                    {
                        Console.WriteLine("Quel objet donner?");
                        Console.WriteLine(pp.monStuff);
                        int index = int.Parse(Console.ReadLine());
                        if (pp.monStuff.voirInventaire()[index] as Cachets != null)
                        {
                            Etat = "Sommeil";
                            pp.monStuff.supprimerItem(index - 1);
                            Console.WriteLine("Il s'est endormi");
                        }
                        else
                        {
                            pp.monStuff.supprimerItem(index - 1);
                            Console.WriteLine("Merci infiniment");
                        }
                    }
                }
                if (((pp.Persuasion * 100) / accepter_objet) < 25)
                {
                    Console.WriteLine("Désolé, je ne peux rien accepter des patients");
                }
            }
        }

        public Personnel_medical() : base()
        {
            Sante = 20;
            Relation = 20;
        }
    }
}
