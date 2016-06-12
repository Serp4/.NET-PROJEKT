using Projekt_na_zaliczenie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Projekt_na_zaliczenie
{
    public class BazaDanych : Baza, IEquatable<BazaDanych>
    {
        public String pytanie { get; set; }
        public String wariant_A { get; set; }
        public String wariant_B { get; set; }
        public String wariant_C { get; set; }
        public String wariant_D { get; set; }
        public String odpowiedz { get; set; }

        public BazaDanych(String pytaniee, String wariant_a, String wariant_b, String wariant_c, String wariant_d, String poprawdzna_odpowiedz)
        {
            this.pytanie = pytaniee;
            this.wariant_A = wariant_a;
            this.wariant_B = wariant_b;
            this.wariant_C = wariant_c;
            this.wariant_D = wariant_d;
            this.odpowiedz = poprawdzna_odpowiedz;
        }

        public BazaDanych() { }

        public bool Equals(BazaDanych other)
        {
            if (other.pytanie == null)
                return false;
            if (this.pytanie == other.pytanie)
            {
                return true;
            }
            else
                return false;
        }
    }
}




