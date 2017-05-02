using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Stuff
    {
        static int taille = 10;
        private List<Object_jeu> elements = new List<Object_jeu>(); 

        public void ajouterItem(Object_jeu obj)
        {
            if(elements.Count<10)
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

        public void jeterItem()
        {
            Console.WriteLine("Quel objet jeter?");
            for(int i=0;i<elements.Count;i++)
            {
                Console.WriteLine("{0} : {1}", i, elements[i].nom);
            }
            int rejet = int.Parse(Console.ReadLine());
            elements.RemoveAt(rejet);
        }

        public void supprItem(int index)
        {
            Console.WriteLine("L'objet {0} a été supprimé", elements[index].nom);
            elements.RemoveAt(index);
        }

        public override String ToString()
        {
            string affiche = "";
            for(int i = 0;i<elements.Count;i++)
            {
                affiche += ""+(i+1)+" : "+elements[i].nom + "\n";
            }
            return affiche;
        }
    }
}
