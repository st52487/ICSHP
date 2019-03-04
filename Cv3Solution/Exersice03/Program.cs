using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;
using Cv3Exersice.Cv3Library;
using Cv3Exersice.Flow;

namespace Exersice03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Random number: {RandomNumberGenerator.GetNext()}"); 
            ConversionTest.DoIt();
            OverFlowUnderFlow.DoIt();
        }
    }
}
