using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Lavabo : Objet_Environnement
    {
        public Lavabo() : base("lavabo") { }

        public void laverMains(Perso_principal perso)
        {
            perso.Sex_appeal = perso.Sex_appeal + 3;
        }

        public void boire (Perso_principal perso)
        {
            perso.Sante = perso.Sante + 7;
        }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("1 : Se laver les mains");
            Console.WriteLine("2 : Boire de l'eau");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                laverMains(perso);
            }
            if (action == 2)
            {
                boire(perso);
            }
        }

        public override string ToString()
        {
            return ("un lavabo");
        }

    }
}
