using System;
using System.Collections.Generic;
using System.Text;

namespace Vital

{
    public class Range
    {
        public static bool CheckRange(float value, int lowerLimit, int higherLimit, String vital)
        {
            if (value < lowerLimit)
            {
                Console.WriteLine(vital + " low " + value);
                return false;
            }
            if (value > higherLimit)
            {
                Console.WriteLine(vital + " high " + value);
                return false;
            }
            return true;
        }
    }
}
