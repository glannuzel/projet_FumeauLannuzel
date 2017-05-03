using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    class GrosBras : Patient
    {
        public GrosBras() : base()
        {
            Sante = 95;
            Relation = 95;
            Force = 95;
            
        }
        public override string ToString()
        {
            return "Tu es un homme mort";
        }
    }
}
