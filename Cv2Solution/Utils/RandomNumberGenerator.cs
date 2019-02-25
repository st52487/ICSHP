using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    /// <summary>
    /// Random number generator with [-10, 10] range.
    /// </summary>
    public static class RandomNumberGenerator
    {
        const int MAX_VALUE = 10;
        const int MIN_VALUE = -10;
        static Random rnd = new Random();

        public static void GetClassName()
        {
            Console.WriteLine(nameof(RandomNumberGenerator));
        }

        public static int GetNext()
        {
            return rnd.Next(MIN_VALUE,MAX_VALUE);
        }
    }
}
