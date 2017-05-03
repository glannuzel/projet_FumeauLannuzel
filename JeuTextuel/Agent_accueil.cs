using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Agent_accueil : Personnel_etablissement
    {
        private int draguer;
        public int Draguer
        {
            get { return draguer; }
            set { draguer = value; }
        }

        public Agent_accueil() : base()
        {

            Draguer = 50;
            Accepter_objet = 30;


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

        public override String ToString()
        {
            string affiche = "Bonjour je m'appelle : " + Nom + "\nJe suis agent d'accueil ";
            return affiche;
        }
    }
}
