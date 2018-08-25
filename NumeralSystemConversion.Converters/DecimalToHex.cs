using System;
using System.Collections.Generic;

namespace NumeralSystemConversion.Converters
{
    public class DecimalToHex
    {
        private const double Base = 16.0;
        private Dictionary<int, string> _codes = new Dictionary<int, string>
        {
            { 1, "1" },
            { 2, "2" },
            { 3, "3" },
            { 4, "4" },
            { 5, "5" },
            { 6, "6" },
            { 7, "7" },
            { 8, "8" },
            { 9, "9" },
            { 10, "A" },
            { 11, "B" },
            { 12, "C" },
            { 13, "D" },
            { 14, "E" },
            { 15, "F" }
        };
        
        public string Convert(int input)
        {
            var result = string.Empty;
            var remainders = new Stack<int>();
            double value = input / Base;

            while (value > 0)
            {
                double left = Math.Truncate(value);
                double right = value - left;

                double remainder = right * Base;
                remainders.Push((int)remainder);
                value = left / Base;
            }
            
            foreach(var r in remainders)
            {
                result += _codes[r];
            }

            return result;
        }
    }
}
