using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuTextuel
{
    class Perso_principal
    {
        private int sante;
        public int Sante
        {
            get { return sante; }
            set
            {
                if (sante + value <= 100 && sante + value >= 0)
                { sante += value; }
                else
                {
                    if (sante + value > 100)
                    {
                        sante = 100;
                        Console.WriteLine("Santé au maximum");
                    }
                    if (sante + value < 0)
                    {
                        Console.WriteLine("Santé au minimum");
                        sante = 0;
                    }
                }
            }
        }

        private int persuasion;
        public int Persuasion
        {
            get { return persuasion; }
            set
            {
                if (persuasion + value <= 100 && persuasion + value >= 0)
                { persuasion += value; }
                else
                {
                    if (persuasion + value > 100)
                    {
                        persuasion = 100;
                        Console.WriteLine("Persuasion au maximum");
                    }
                    if (persuasion + value < 0)
                    {
                        persuasion = 0;
                        Console.WriteLine("Persuasion au minimum");
                    }
                }
            }
        }

        private int force;
        public int Force
        {
            get { return force; }
            set
            {
                if (force + value <= 100 && force + value >= 0)
                { force += value; }
                else
                {
                    if (force + value > 100)
                    {
                        force = 100;
                        Console.WriteLine("Force au maximum");
                    }
                    if (force + value < 0)
                    {
                        force = 0;
                        Console.WriteLine("Force au minimum");
                    }
                }
            }
        }

        private int sex_appeal;
        public int Sex_appeal
        {
            get { return sex_appeal; }
            set
            {
                if (sex_appeal + value <= 100 && sex_appeal + value >= 0)
                { sex_appeal += value; }
                else
                {
                    if (sex_appeal + value > 100)
                    {
                        sex_appeal = 100;
                        Console.WriteLine("Sex-Appeal au maximum");
                    }
                    if (sex_appeal + value < 0)
                    {
                        sex_appeal = 0;
                        Console.WriteLine("Sex-Appeal au minimum");
                    }
                }
            }
        }

        public Stuff monStuff;
        public Stuff GetStuff()
        {
            return monStuff;
        }

        private Salle position;

        public Perso_principal(Salle position)
        {
            force = 30;
            sex_appeal = 30;
            sante = 100;
            persuasion = 30;
            monStuff = new Stuff();
            this.position = position;
        }

        public Salle Position
        {
            get { return position; }
            set { position = value; }
            
        }
        

    }
}
