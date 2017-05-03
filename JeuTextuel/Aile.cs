using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Aile
    {
        private string nom;
        private List<Salle> composition;

        public Aile(string nom)
        {
            this.nom = nom;
            composition = new List<Salle>();
        }

        public void ajouterSalle(Salle salle)
        {
            composition.Add(salle);
        }

        public string Nom
        { get { return nom; } }

        public override string ToString()
        {
            return (nom);
        }
    }
}
