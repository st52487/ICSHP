using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaMistru
{
    public class Hrac
    {
        public string Jmeno { get; set; }
        public FotbalovyKlub Klub { get; set; }
        public int GolPocet { get; set; }

        public override bool Equals(object obj)
        {
            var hrac = obj as Hrac;
            return hrac != null &&
                   Jmeno == hrac.Jmeno &&
                   Klub == hrac.Klub &&
                   GolPocet == hrac.GolPocet;
        }
    }
}
