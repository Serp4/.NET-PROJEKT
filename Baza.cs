using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_na_zaliczenie
{
    public abstract class Baza
    {
        string Question;
        string A;
        string B;
        string C;
        string D;
        string Answer;

        public virtual bool Equals(Baza other)
        {
            return true;
        }
    }
}
