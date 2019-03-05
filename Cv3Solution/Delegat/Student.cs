using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    enum Fakulta
    {
        FES, FF, FEI, FCHT
    };

    class Student
    {

        private string Jmeno { get; set; }
        private int Cislo { get; set; }
        private Fakulta Fakulta { get; set; }

        public Student(string jmeno, int cislo, Fakulta fakulta)
        {
            this.Jmeno = jmeno;
            this.Cislo = cislo;
            this.Fakulta = fakulta;
        }

        public override string ToString()
        {
            return "Student cislo " + Cislo.ToString() + ", " + Jmeno.ToString() + ", " + GetName(Fakulta);
        }

        public string GetName(Fakulta value)
        {
            return Enum.GetName(typeof(Fakulta), value);
        }
    }
}
