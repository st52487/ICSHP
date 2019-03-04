using System;

namespace Cv3Exersice.Flow
{
    public static class OverFlowUnderFlow
    {
        public static void DoIt()
        {
            uint max = uint.MaxValue;
            uint min = uint.MinValue;

            Console.WriteLine($"max: {max}, min: {min}");
            unchecked
            {
                max++;
                min++;
            }
            Console.WriteLine($"max: {max}, min: {min}");
        }
    }
}
