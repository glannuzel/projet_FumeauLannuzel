using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    abstract class Livre : Objet_Inventaire
    {
        public Livre(string nom) : base(nom) { }

        public abstract void lire(Perso_principal perso);

        public void arracherPages(Perso_principal perso)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("J'ai envie d'arracher quelques pages de ce livre. De toute façon, personne ne le verra...\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Souhaitez-vous prendre les pages arrachées ? (o/n)");
            string reponse = Console.ReadLine();
            while (reponse != "o" && reponse != "n")
            { 
                Console.WriteLine("Commande invalide. Taper 'o' pour valider, ou 'n' pour refuser");
                reponse = Console.ReadLine();
            }
            if (reponse == "o")
            {
                perso.monStuff.ajouterItem(new PagesLivre());
            }
            else
            {
                perso.Position.ajouterDansSalle(new PagesLivre());
            }
        }
    }
}
