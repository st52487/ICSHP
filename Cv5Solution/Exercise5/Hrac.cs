using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Hrac
    {
        public Hrac(String jmeno, FotbalovyKlub kl, int golu)
        {
            this.Jmeno = jmeno;
            this.Klub = kl;
            this.GolPocet = golu;
        }
        public string Jmeno { get; set; }
        public FotbalovyKlub Klub { get; set; }
        public int GolPocet { get; set; }

        public override string ToString()
        {
            return "Jméno: " + Jmeno + " " + "Klub: " + Klub.ToString() + " " + "Počet gólů: " + GolPocet;
        }
    }
}
