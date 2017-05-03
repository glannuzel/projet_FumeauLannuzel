using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation d'une aile Nord
            Aile aileNord = new Aile("Aile NORD");

            //Creation des objets disponibles dans une salle de bain
            List<Objet> objSdb = new List<Objet>();
            objSdb.Add(new Douche());
            objSdb.Add(new Toilettes());
            objSdb.Add(new Lavabo());
            objSdb.Add(new Miroir());

            //Creation des objets disponibles dans une chambre
            List<Objet> objChambre = new List<Objet>();
            objChambre.Add(new Placard(true, new Cintre()));
            objChambre.Add(new Lit());
            objChambre.Add(new Fauteuil());

            //Creation des objets disponibles dans un couloir
            List<Objet> objCouloir = new List<Objet>();
            objCouloir.Add(new Bouche_aeration());
            objCouloir.Add(new Bouche_aeration());
            objCouloir.Add(new Bouche_aeration());

            //Creation d'une salle de bain dans l'aile Nord
            Salle sdb226 = new Salle("Salle de bain de la Chambre 226", aileNord, objSdb);

            //Creation d'une chambre dans l'aile Nord
            Salle chambre226 = new Salle("Chambre 226", aileNord, objChambre);

            //Creation du couloir de l'aile Nord, non accessible
            Salle couloirNord = new Salle("Couloir", false, aileNord, objCouloir);

            //Mise en place relation de salles voisines entre sdb et chambre
            sdb226.indiquerSalleAdjacente(chambre226);

            //Mise en place relation de salles voisines entre chambre et couloir
            chambre226.indiquerSalleAdjacente(couloirNord);

            //Creation du personnage principal de la partie
            Perso_principal smith = new Perso_principal(chambre226);


            //Début du jeu
            partie1(smith);
            

            
        }

        //Choix de la commande d'action par le joueur
        public static void queFaire(Perso_principal perso)
        {
            string action = Console.ReadLine();
            do
            {
                if (action == "aide")
                {
                    Console.WriteLine("Pour réaliser les actions ci-dessous, taper la lettre associée");
                    Console.WriteLine("e : explorer - permet d’obtenir une description de votre environnement");
                    Console.WriteLine("i : inventaire - permet d’accéder à votre inventaire à tout moment");
                    Console.WriteLine("f : faire - permet d’interagir avec une personne ou un objet");
                    Console.WriteLine("o : objectifs - permet de connaître les objectifs de la quête principale et des quêtes secondaires en cours");
                    Console.WriteLine("d : déplacer - permet de vous déplacer dans une autre salle ou aile");
                    Console.WriteLine("q : QUITTER LE JEU\n");
                    action = Console.ReadLine();
                }
                if (action != "aide" && action != "e" && action != "i" && action != "f" && action != "o" && action != "d" && action != "q") 
                {
                    Console.WriteLine("Commande non valide. Taper \"aide\" pour accéder aux commandes disponibles");
                    action = Console.ReadLine();
                }
            } while (action != "e" && action != "i" && action != "f" && action != "o" && action != "d" && action != "q");
            if (action == "e")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" # Explorer");
                Console.ForegroundColor = ConsoleColor.White;
                decrireEnvironnement(perso.Position);
                queFaire(perso);
            }
            if (action == "i")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" # Inventaire");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(perso.monStuff);
                if (perso.monStuff.voirInventaire().Count == 0)
                {
                    Console.WriteLine("L'inventaire est vide.\n");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Santé : {0}", perso.Sante);
                Console.WriteLine("Force : {0}", perso.Force);
                Console.WriteLine("Persuasion : {0}", perso.Persuasion);
                Console.WriteLine("Sex-appeal : {0}\n", perso.Sex_appeal);
                Console.ForegroundColor = ConsoleColor.White;
                queFaire(perso);
            }
            if (action == "f")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("# Avec quel objet ou quelle personne interagir ?\n");
                Console.ForegroundColor = ConsoleColor.White;
                int numObj = 1;
                foreach (Objet objet in perso.Position.GetListeObjets())
                {
                    Console.WriteLine("{0} : {1}", numObj, objet);
                    numObj++;
                }
                /*
                int numPNJ = 1;
                foreach (PNJ pnj in perso.Position.GetListePNJ())
                {
                    Console.WriteLine("{0} : {1}", numObj + numPNJ, pnj);
                    numPNJ++;
                }*/
                Console.WriteLine("0 : annuler");
                int reponse = int.Parse(Console.ReadLine());
                if (reponse == 0)
                {
                    Console.WriteLine("Que faire ?");
                    queFaire(perso);
                }
                if (reponse <0 || reponse > (perso.Position.GetListeObjets().Count)) //+ perso.Position.GetListePNJ().Count)
                {
                    Console.WriteLine("Commande non valide. Choisir le numéro d'un objet ou personnage proposé.");
                }
                else
                {
                    if (reponse <= perso.Position.GetListeObjets().Count)
                    {
                        Objet_Environnement obj = perso.Position.GetListeObjets()[reponse - 1] as Objet_Environnement;
                        if (obj != null)
                        {
                            obj.interagir(perso, perso.GetStuff());
                        }
                        else
                        {
                            Objet_Inventaire objInv = perso.Position.GetListeObjets()[reponse - 1] as Objet_Inventaire;
                            objInv.prendre(perso.GetStuff());
                        }
                    }
                    /*else
                    {
                        PNJ personnage = perso.Position.GetListePNJ()[reponse - numObj - 1]
                        personnage.interagir();
                    }*/
                }
                queFaire(perso);
            }
            if (action == "o")
            {
                
            }
            if (action == "d")
            {
                seDeplacer(perso);
            }
            if (action == "q")
            {
                Console.Clear();
                Console.WriteLine("Etes-vous sûr de vouloir quitter le jeu ? (o/n)");
                string reponse = Console.ReadLine();
                while (reponse != "o" && reponse !="n")
                {
                    Console.WriteLine("Commande non valide. Taper \'o\' pour quitter, ou \'n\' pour annuler");
                    reponse = Console.ReadLine();
                }
                if (reponse == "o")
                {
                    Environment.Exit(0);
                }
                if (reponse == "n")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("# Reprise de la partie\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" --- " + perso.Position.GetAile() + ", " + perso.Position);
                    Console.WriteLine("Que faire ?");
                    queFaire(perso);
                }
            }
        }

        public static void decrireEnvironnement(Salle salle)
        {
            int nbObjet = salle.GetListeObjets().Count;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Je vois ");
            int k = 0;
            while (k < nbObjet-1)
            {
                Console.Write("{0}, ", salle.GetListeObjets()[k]);
                k++;
            }
            Console.WriteLine("et {0}.\n", salle.GetListeObjets()[k]);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void seDeplacer(Perso_principal perso)
        {
            List<Salle> voisines = perso.Position.GetSallesAdjacentes();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("# Se déplacer vers ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < voisines.Count; i++)
            { Console.WriteLine("{0} : {1}", i+1, voisines[i]); }
            Console.WriteLine("0 : rester où je suis");
            int reponse = int.Parse(Console.ReadLine());
            while (reponse > voisines.Count || reponse < 0)
            {
                Console.WriteLine("Commande non valide. Choisir un chiffre parmi les propositions.");
            }
            if (reponse != 0)
            {
                if (voisines[reponse - 1].GetOuverte() == true)
                {
                    perso.Position = voisines[reponse - 1];
                    Console.Clear();
                    Console.WriteLine(" --- " + perso.Position.GetAile() + ", " + perso.Position);
                    queFaire(perso);
                }
                else
                {
                    voisines[reponse - 1].ouvrirSalle(perso);
                    queFaire(perso);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Je vais rester dans cette pièce encore un instant.\n");
                Console.ForegroundColor = ConsoleColor.White;
                queFaire(perso);
            }
        }


        //Parties du scénario
        public static void partie1(Perso_principal perso)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***.........AAAAAAAAAAAAAAAHHH…………A L’AAAAAAIDE……………. \nAAAAAAAAHHH…………… AU SECOOOOOURS…..***");
            //Thread.CurrentThread.Sleep(200);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" --- " + perso.Position.GetAile() + ", " + perso.Position);
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Thread.CurrentThread.Sleep(200);
            Console.Write("\nHAAN ! ");
            Console.ForegroundColor = ConsoleColor.White;
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("*Réveil en sursaut *");
            //Thread.CurrentThread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Encore un cauchemar.");
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("Ces cris qui résonnent dans ma tête toutes les nuits….");
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("Ils m’empêchent de dormir. J’ai peur de dormir, mes nuits sont hantées par ces voix.");
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("Mon front dégouline encore, j'ai des sueurs…");
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("Et mon coeur, il s’est encore emballé ! Il faut que je me calme.");
            Console.ForegroundColor = ConsoleColor.White;
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("\nQue faire ?");
            string reponse;
            do
            {
                Console.WriteLine("\n1 : Essayer de se rendormir");
                Console.WriteLine("2 : Se lever");
                reponse = Console.ReadLine();
                if (reponse != "1" && reponse != "2")
                {
                    Console.WriteLine("Commande invalide.");
                }
                if (reponse == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Je n'y arrive pas, ca ne sert à rien.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (reponse != "2");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Allez, je me lève, ça va me faire du bien.");
            //Thread.CurrentThread.Sleep(200);
            Console.WriteLine("Mais où suis-je ? Je ne reconnais rien.");
            //Thread.CurrentThread.Sleep(200);
            decrireEnvironnement(perso.Position);
            //Thread.CurrentThread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("On dirait.... la chambre d'un hôpital !! Mais qu'est-ce que je fais ici, que m'est-il arrivé ?");
            //Thread.CurrentThread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nTaper 'aide' lorsque vous souhaitez connaître les actions disponibles");
            queFaire(perso);
        }
    }
}
