using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Medecin : Personnel_medical
    {
        private static int nbHypno= 0;

        private string type;

        public string Type
        {
            get { return type; }
            set {
                if(nbHypno==0)
                {
                    type = value;
                }
                else
                {
                    type = "Normal";
                }
                
            }
        }


        public Medecin(string type) : base()
        {
            Random randInt = new Random();
            Draguer = 60;
            Accepter_objet = 60;
            Relation = 10;
            this.Type = type;
            if(type=="hypno")
            {
                nbHypno = 1;
            }
        }

        public void consultation()
        {
            Console.WriteLine("yo");
        }

        public override string ToString()
        {
            return "Bonjour je suis un médecin "+Type+", je m'appelle " + Nom + "\nVous voulez quelque chose?";
        }
    }
}
