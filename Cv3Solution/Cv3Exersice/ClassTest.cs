using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv3Exersice
{
    internal class MyInteger
    {
        //public uint Value { get; set; }

        public uint Value
        {
            get
            {
                return Value;
            }
            set
            {
                Value = value;
            }
        }

        private static int GetMaxInt() { return int.MaxValue; }

        public bool Signed { get; private set; }

        public MyInteger()
        {
         
        }

        public MyInteger(uint value, bool signed)
        {
            Value = value;
            Signed = signed;
        }

        public static implicit operator MyInteger(int v)
        {
            return new MyInteger() { Value = (uint)Math.Abs(v), Signed = v < 0 };
        }
    }
    class ClassTest
    {
        public static void DoIt()
        {
            MyInteger myInteger = new MyInteger() { Value = 33 };
            MyInteger myInteger2 = new MyInteger(33, true);


            MyInteger myInteger3 = 125;
        }

    }
}
