﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Lit : Confort
    {
        public Lit() : base("lit") { }

        public override void asseoir(Perso_principal perso)
        {
            perso.Sante = perso.Sante + 3;
            perso.Force = perso.Force + 3;
        }

        public void dormir(Perso_principal perso)
        {
            perso.Sante = perso.Sante + 10;
            perso.Force = perso.Force + 5;
        }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("1 : S'asseoir sur le lit");
            Console.WriteLine("2 : Dormir");
            string reponse = Console.ReadLine();
            while (reponse != "1" && reponse != "2")
            {
                Console.WriteLine("Commande non valide. Sélectionner une réponse parmi les choix proposés.");
                reponse = Console.ReadLine();
            }
            if (reponse == "1")
            {
                Console.WriteLine("Allez, je peux bien m\'asseoir 2 minutes.");
                asseoir(perso);
            }
            if (reponse == "2")
            {
                Console.WriteLine("Un peu de sommeil ne me fera pas de mal.");
                dormir(perso);
            }
        }

        public override string ToString()
        {
            return ("un lit");
        }
    }
}
