using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Personnel_etablissement : PNJ
    {
        private int service;
        public int Service
        {
            get { return service; }
            set { service = value; }
        }

        private int accepter_objet;
        public int Accepter_objet
        {
            get { return accepter_objet; }
            set { accepter_objet = value; }
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

        public Personnel_etablissement() : base()
        {

        }
    }
}
