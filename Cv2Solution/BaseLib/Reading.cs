using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fei
{
    namespace BaseLib
    {
        /// <summary>
        ///  staticka trida reading
        /// </summary>
        public static class Reading
        {
            /// <summary>
            /// Nacte double z klavesnice
            /// </summary>
            /// <returns>vraci double hodnotu</returns>
            public static double ReadDouble()
            {
                Console.WriteLine("Nacti double: ");
                return Double.Parse(Console.ReadLine());
            }

            /// <summary>
            /// Nacte int z klavesnice
            /// </summary>
            /// <returns>Vraci int</returns>
            public static int ReadInt()
            {
                Console.WriteLine("Nacti int: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            /// <summary>
            /// Nacte cjar z klavesnice
            /// </summary>
            /// <returns>Vraci char</returns>
            public static char ReadChar()
            {
                Console.WriteLine("Nacti char: ");
                return Console.ReadKey().KeyChar;
            }

            /// <summary>
            /// Nacte retezec z klavesnice
            /// </summary>
            /// <returns>Vraci string</returns>
            public static string ReadString()
            {
                Console.WriteLine("Nacti string: ");
                return Console.ReadLine();
            }
        }
    }
}
