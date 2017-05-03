using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Fauteuil : Confort
    {
        public Fauteuil() : base("fauteuil") { }

        public override void asseoir(Perso_principal perso)
        {
            perso.Sante = perso.Sante + 2;
            perso.Force = perso.Force + 2;
        }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("Owh, un fauteuil ! Je pourrais bien me poser 2 minutes.\nS'asseoir ? (o/n)");
            string reponse = Console.ReadLine();
            while (reponse != "o" && reponse != "n")
            {
                Console.WriteLine("Taper \'o\' pour s'asseoir sur le fauteuil et \'n\' pour annuler");
                reponse = Console.ReadLine();
            }
            if (reponse == "o")
            {
                Console.WriteLine("Ah, une petite pause ça fait toujours du bien.");
                asseoir(perso);
            }
            if (reponse == "n")
            {
                Console.WriteLine("Non, je n\'ai pas le temps. J'ai autre chose à faire.");
            }
        }

        public override string ToString()
        {
            return ("un fauteuil");
        }
    }
}
