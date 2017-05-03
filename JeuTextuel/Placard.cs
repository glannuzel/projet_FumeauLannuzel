using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Placard : Cachette
    {
        bool ouvert;
        public Placard() : base("placard")
        {
            Random a = new Random(2);
            int alea = a.Next();
            if (alea == 0)
            { ouvert = true; }
            else { ouvert = false; }
        }

        public Placard(bool ouvert, Objet_Inventaire obj) : base("placard")
        {
            this.ouvert = ouvert;
            contenu = obj;
        }

        public void seCacherDedans(Perso_principal perso)
        {
            perso.Sex_appeal = perso.Sex_appeal - 10;
            perso.Persuasion = perso.Persuasion - 5;
        }

        public override void interagir(Perso_principal perso, Stuff inventaire)
        {
            Console.WriteLine("1 : Se cacher dans le placard");
            Console.WriteLine("2 : Fouiller");
            int action = int.Parse(Console.ReadLine());
            if (action == 1)
            {
                seCacherDedans(perso);
            }
            if (action == 2)
            {
                if (ouvert == true)
                {
                    fouiller(inventaire);
                }
                else
                {
                    Console.WriteLine("Ce placard est fermé à clé.");
                    int nbClefs = 0;
                    foreach (Objet_Inventaire item in inventaire.voirInventaire())
                    {
                        Clef clef = item as Clef;
                        if (clef != null)
                        { nbClefs++; }
                    }
                    if (nbClefs != 0)
                    {
                        Console.WriteLine("Il me reste {0} clés dans mon inventaire. J'en utilise une pour ouvrir ce placard ? (o/n)",nbClefs);
                        string reponse = Console.ReadLine();
                        while (reponse != "o" && reponse != "n")
                        {
                            Console.WriteLine("Taper \"o\" pour utiliser une clé, ou \"n\" pour abandonner");
                            reponse = Console.ReadLine();
                        }
                        if (reponse == "o")
                        {
                            List<Objet_Inventaire> mesObjets = inventaire.voirInventaire();
                            Objet_Inventaire item = mesObjets[0];
                            int n = 0;
                            while (item as Clef == null)
                            {
                                item = mesObjets[n + 1];
                            }
                            inventaire.supprimerItem(item);
                            fouiller(inventaire);
                        }
                        else { Console.WriteLine("Bon, je verrai une prochaine fois."); }
                    }
                    else
                    {
                        Console.Write("Je n'ai pas de clé sur moi, je ne peux pas ouvrir ce placard.");
                    }
                }
            }
        }

        public override string ToString()
        {
            return ("un placard");
        }
    }
}
