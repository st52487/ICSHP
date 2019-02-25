using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Cviceni02
{
    class Program
    {

        static void WorkWithStaticClass()
        {
            RandomNumberGenerator.GetClassName();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(RandomNumberGenerator.GetNext());
            }
        }

        private static void WorkWithDataTypes()
        {
            int x = 3;
            int y = x;
            y += 2;
            x++;
            Console.WriteLine($"x: {x}; y: {y}");


            ComplexNumber number1 = new ComplexNumber(1,2,3);
            //ComplexNumber number2 = number1;
            ComplexNumber number2 = new ComplexNumber(number1);

            number2.First += 2;
            number2.Second++;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
        }

        private static void WorkWithNullableTypes()
        {
            int number1 = 3;
            int? number2 = null;
            ComplexNumber number3 = null;
            if (number2.HasValue)
            {
                int number4 = number2.Value;
            }
            number3?.Third?.GetType();
            ComplexNumber number5 = new ComplexNumber(1, 2, null);
            number5?.Third?.GetType();
        }

        private static bool TryParse(string text,out int result)
        {
            return int.TryParse(text, out result);
        }

        static void Main(string[] args)
        {
            WorkWithStaticClass();
            WorkWithDataTypes();
            WorkWithNullableTypes();

        }
    }
}
