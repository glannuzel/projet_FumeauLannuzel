using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Salle
    {
        private string nom;
        private Aile aile;
        private bool ouverte;
        private List<Objet> composition;
        private List<Salle> sallesAdjacentes;
        
        public Salle(string nom, Aile aile, List<Objet> objets)
        {
            this.nom = nom;
            this.aile = aile;
            //Ajout de la salle dans l'aile concernée
            aile.ajouterSalle(this);
            composition = new List<Objet>();
            composition = objets;
            sallesAdjacentes = new List<Salle>();
            ouverte = true;
        }

        public Salle(string nom, bool ouverte, Aile aile, List<Objet> objets) : this(nom, aile, objets)
        {
            this.ouverte = ouverte;
        }

        public void indiquerSalleAdjacente(Salle salle)
        {
            sallesAdjacentes.Add(salle);
            salle.sallesAdjacentes.Add(this);
        }

        public string Nom
        { get { return nom; } }

        public void ajouterDansSalle(Objet obj)
        {
            composition.Add(obj);
        }

        public void retirerDeSalle(Objet obj)
        {
            composition.Remove(obj);
        }

        public List<Objet> GetListeObjets()
        {
            return composition;
        }

        public List<Salle> GetSallesAdjacentes()
        {
            return sallesAdjacentes;
        }

        public Aile GetAile()
        {
            return aile;
        }

        public bool GetOuverte()
        {
            return ouverte;
        }

        public void ouvrirSalle(Perso_principal perso)
        {
            if (ouverte == false)
            {
                Stuff inventaire = perso.GetStuff();
                int numObj = 0;
                bool ouverturePossible = false;
                while ((numObj < inventaire.voirInventaire().Count) && (ouverturePossible == false))
                {
                    if ((inventaire.voirInventaire()[numObj] as Clef) != null)
                    {
                        ouverturePossible = true;
                    }
                    if ((inventaire.voirInventaire()[numObj] as Cintre) != null)
                    {
                        ouverturePossible = true;
                    }
                    numObj++;
                }
                if (ouverturePossible == true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("J'ai un objet qui me permet d'ouvrir la porte de cette salle.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("L'utiliser ? (o/n)");
                    string reponse = Console.ReadLine();
                    while (reponse != "o" && reponse != "n")
                    {
                        Console.WriteLine("Commande invalide. Saisir 'o' pour valider l'action, ou 'n' pour refuser.");
                        reponse = Console.ReadLine();
                    }
                    Console.WriteLine("Quel objet prendre ?");
                    Console.WriteLine(perso.monStuff);
                    int objet_choisi = int.Parse(Console.ReadLine());
                    if ((inventaire.voirInventaire()[objet_choisi] as Clef != null) || (inventaire.voirInventaire()[objet_choisi] as Cintre != null))
                    {
                        perso.monStuff.supprimerItem(objet_choisi);
                        ouverte = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Porte déverouillée.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\nVoyons voir ce qui se cache derrière cette porte.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        ouvrirSalle(perso);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Oh non, cette porte est fermée ! Je n'ai aucun objet me permettant d'ouvrir cette porte.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Voyons voir ce qui se cache derrière cette porte.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public override string ToString()
        {
            return (nom);
        }
    }
}
