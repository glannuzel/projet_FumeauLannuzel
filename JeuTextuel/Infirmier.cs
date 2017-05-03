using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Infirmier : Personnel_medical
    {

        private int service;

        public int Service
        {
            get { return service; }
            set { if (service == 0) { service = value; } }
        }

        public Infirmier() : base()
        {

            Draguer = 50;
            Accepter_objet = 30;

        }

        public override String ToString()
        {
            string affiche = "Bonjour je m'appelle : " + Nom + "\nJe suis un(e) infirmier(e) de sexe : ";
            return affiche;
        }
    }
}
