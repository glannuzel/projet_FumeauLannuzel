using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Magazine : Livre
    {
        public Magazine() : base("magazine") { }

        public override void lire(Perso_principal perso)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Regardons un peu les tendances de cet été d'après SexyMan.\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vous avez gagné 5 points de sex-appeal.");
            perso.Sex_appeal = 5;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void lireHoroscope(Perso_principal perso)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Tiens, et si je lisais mon horoscope ! Alors... page 32 ...\n");
            Console.ForegroundColor = ConsoleColor.White;
            Random alea = new Random(5);
            int a = alea.Next();
            if (a == 0)
            {
                Console.WriteLine("Scorpion : Vous avez une santé en béton ! Malheureusement, vous semblez avoir de plus en plus de mal à convaincre les gens de vous écouter...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez gagné 20 points de santé.");
                perso.Sante = 20;
                Console.WriteLine("Vous avez perdu 10 points de persuasion.");
                perso.Persuasion = - 10;
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (a == 1)
            {
                Console.WriteLine("Gémeaux : Vous semblez trouver un frère dans chacune de vos relation. Heureusement qu'ils sont là pour vous soutenir quand les choses vont mal.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez gagné 20 points de persuasion.");
                perso.Persuasion = 20;
                Console.WriteLine("Vous avez perdu 20 points de santé.");
                perso.Sante = -20;
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (a == 2)
            {
                Console.WriteLine("Lion : Vous alliez force et vigueur en ce moment. Tout le monde écoute vos conseils : aucun doute, vous êtes bien le roi de la savane.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez gagné 10 points de santé.");
                perso.Sante = 10;
                Console.WriteLine("Vous avez gagné 10 points de force.");
                perso.Force = 10;
                Console.WriteLine("Vous avez gagné 10 points de persuasion.");
                perso.Persuasion = 10;
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (a == 3)
            {
                Console.WriteLine("Taureau : Vous aimez montrer vos muscles bien travaillés ces jours-ci. Le culturisme c'est bien, mais pas sûr que tout le monde apprécie... Parfois c'est un peu trop.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez gagné 15 points de force.");
                perso.Force = 15;
                Console.WriteLine("Vous avez perdu 10 points de sex-appeal.");
                perso.Sex_appeal = -10;
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (a == 4)
            {
                Console.WriteLine("Vierge : Vous dégagez une aura de sainteté à laquelle personne ne semble résister. Profitez-en !");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vous avez gagné 10 points de sex-appeal.");
                perso.Sex_appeal = 10;
                Console.WriteLine("Vous avez gagné 10 points de persuasion.");
                perso.Persuasion = 10;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
