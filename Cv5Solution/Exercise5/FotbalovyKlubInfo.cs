using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    static class FotbalovyKlubInfo
    {
        public static readonly int pocet = FotbalovyKlub.GetNames(typeof(FotbalovyKlub)).Length;


        public static string DejNazev(FotbalovyKlub klub)
        {
            switch (klub)
            {
                case FotbalovyKlub.Arsenal:
                    return "Arsenal";
                case FotbalovyKlub.Barcelona:
                    return "Barcelona";
                case FotbalovyKlub.Chelsea:
                    return "Chelsea";
                case FotbalovyKlub.FCPorto:
                    return "FC Porto";
                case FotbalovyKlub.None:
                    return "Žádný";
                case FotbalovyKlub.RealMadrid:
                    return "Real Madrid";
            }
            return null;
        }
    }
}
