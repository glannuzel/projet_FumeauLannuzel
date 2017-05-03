using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Miroir : Objet_Environnement
    {
        public Miroir() : base("miroir") { }
        
        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            if (nom != "miroir brisé")
            {
                Console.WriteLine("\n1 : Se regarder dans le miroir");
                Console.WriteLine("2 : Briser le miroir");
                int action = int.Parse(Console.ReadLine());
                if (action == 1)
                { seRegarder(perso); }
                if (action == 2)
                { briserMiroir(perso); }
            }
            else { Console.WriteLine("Ce miroir est brisé, je ne peux rien en faire."); }
        }

        public void seRegarder(Perso_principal perso)
        {
            perso.Sex_appeal = 10;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ouah, la vache, je suis beau !");
            Console.WriteLine("Je ne me souvenais pas être aussi attirant.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVous avez gagné 10 points de sex-appeal.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }        
        
        public void briserMiroir(Perso_principal perso)
        {
            perso.Sante = - 5;
            nom = "miroir brisé";
            perso.Position.ajouterDansSalle(new DebrisMiroir());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Miroir brisé.");
            Console.WriteLine("Vous avez perdu 5 points de santé.\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override string ToString()
        {
            return ("un " + nom);
        }
    }
}
