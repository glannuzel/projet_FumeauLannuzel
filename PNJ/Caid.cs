using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class Caid : Patient
    {
        public Caid() : base()
        {
            Sante = 75;
            Force = 70;
            Relation = 85;
        }
        public override string ToString()
        {
            return "Tu veux te battre??";
        }
    }
}
