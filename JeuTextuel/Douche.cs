using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Douche : Objet_Environnement
    {
        public Douche() : base("douche") { }

        public void seLaver(Perso_principal perso)
        {
            perso.Sex_appeal = 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Allez, à la douche !");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVous avez gagné 10 points de sex-appeal.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void prendreDoucheFroide(Perso_principal perso)
        {
            perso.Force = 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Une petite douche pour améliorer la circulation sanguine, y'a que ça de vrai.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVous avez gagné 10 points de force.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("1 : Se laver");
            Console.WriteLine("2 : Prendre une douche froide");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                seLaver(perso);
            }
            if (action == 2)
            {
                prendreDoucheFroide(perso);
            }
        }

        public override string ToString()
        {
            return ("une douche");
        }
    }
}
