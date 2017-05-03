using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Stuff
    {
        static int taille = 10;
        private List<Objet_Inventaire> elements = new List<Objet_Inventaire>();

        public void ajouterItem(Objet_Inventaire obj)
        {
            if (elements.Count < taille)
            {
                elements.Add(obj);
                Console.WriteLine("Elément ajouté");
            }
            else
            {
                Console.WriteLine("Inventaire plein\nJeter un éléments? (o/n)");
                char valid = char.Parse(Console.ReadLine());
                if (valid == 'o')
                {
                    jeterItem();
                    elements.Add(obj);
                }
                else
                {
                    Console.WriteLine("Objet non ajouté");
                }
            }
        }

        public void supprimerItem(int index)
        {
            Console.WriteLine("L'objet {0} a été supprimé de l'inventaire", elements[index].nom);
            elements.RemoveAt(index);
        }

        public void jeterItem()
        {
            Console.WriteLine("Quel objet jeter?");
            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine("{0} : {1}", i, elements[i].nom);
            }
            int rejet = int.Parse(Console.ReadLine());
            elements.RemoveAt(rejet);
        }

        public override String ToString()
        {
            string affiche = "";
            for (int i = 0; i < elements.Count; i++)
            {
                affiche += "" + i + " : " + elements[i].nom + "\n";
            }
            return affiche;
        }

        public List<Objet_Inventaire> voirInventaire()
        {
            return elements;
        }
    }
}
