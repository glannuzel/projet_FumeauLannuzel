using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Map nnn = new Map(30, 30);
            Console.SetWindowSize(170, 45);
            // Console.Write(nnn);
            //perso p = new perso();
            //nnn.setPerso(p);
            //nnn.boxAlea();
            //nnn.arbre();
            //Console.Write(nnn);
            //simulTour a = new simulTour(5);
            //ajouer();
            /* int[] position = new int[2];
             string[,] m = new string[10, 10];
             position[0] = 10;
             position[1] = 10;
             Maison maison = new Maison(4,position, nnn,2);
             Console.Write(nnn);*/
            /* for (int i = 0; i < position[0]; i++)
             {
                 for (int j = 0; j < position[1]; j++)
                 {
                     if (i == 0 || i == position[0]-1)
                     {
                         m[i, j] = "-";
                     }
                     if((j==0||j==position[1]-1)&& i!=0 &&i!=position[0]-1)
                     {
                         m[i, j] = "|";
                     }
                     if (i != 0 && j != 0 && i != position[0] - 1 && j != position[1]-1)
                     {
                         m[i, j] = "a";
                     }
                 }
             }*/
            /*string affiche ="";
            for(int i = 0; i < position[0];i++)
            {
                affiche += "\n";
                for(int j=0;j<position[1];j++)
                {
                    affiche += m[i,j];
                }
            }*/
            // Console.Write(nnn);
            Object_jeu obj = new Object_jeu("a");
            Object_jeu obj1 = new Object_jeu("banane");
            Object_jeu obj2 = new Object_jeu("c");
            Object_jeu obj3 = new Object_jeu("d");
            
            Perso_principal test = new Perso_principal();
            test.monStuf.ajouterItem(obj);
            test.monStuf.ajouterItem(obj1);
            test.monStuf.ajouterItem(obj2);
            test.monStuf.ajouterItem(obj1);
            test.monStuf.ajouterItem(obj2);
            test.monStuf.ajouterItem(obj1);
            test.monStuf.ajouterItem(obj3);
            test.monStuf.ajouterItem(obj1);
            test.monStuf.ajouterItem(obj2);
            test.monStuf.ajouterItem(obj3);
            test.Sex_appeal = 60;
            Console.WriteLine(test.Sex_appeal);
            // test.monStuf.ajouterItem(new Object_jeu("hache"));
            //Console.Write(test.monStuf);
            test.Sante = -30;
            test.alerte();
            test.manger();
            Console.WriteLine("Besion de qqch ? (o/n)");
            if(Console.ReadLine()=="ui")
            {
                Console.WriteLine("Que voulez-vous?");
                if(Console.ReadLine()=="place")
                {
                    Console.WriteLine("Je suis en : {0},{1}", test.x, test.a);
                }
            }
            Console.Write(test);
            Console.Write("fini");
            Console.ReadKey();
        }
    }
}
