using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Essai : Livre
    {
        public Essai() : base ("essai") { }

        public override void lire(Perso_principal perso)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cultivons-nous un peu, cet essai à l'être absolument passionnant.\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vous avez gagné 10 points de persuasion.");
            perso.Persuasion = 10;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override string ToString()
        {
            return ("un essai");
        }
    }
}
