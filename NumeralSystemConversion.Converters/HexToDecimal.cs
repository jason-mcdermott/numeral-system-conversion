
using System;
using System.Collections.Generic;

namespace NumeralSystemConversion.Converters
{
    public class HexToDecimal
    {
        private const double Base = 16.0;
        private readonly Dictionary<string, int> _codes = new Dictionary<string, int>
        {
            ["1"] = 1, 
            ["2"] = 2, 
            ["3"] = 3, 
            ["4"] = 4, 
            ["5"] = 5, 
            ["6"] = 6, 
            ["7"] = 7, 
            ["8"] = 8, 
            ["9"] = 9, 
            ["A"] = 10,
            ["B"] = 11,
            ["C"] = 12,
            ["D"] = 13,
            ["E"] = 14,
            ["F"] = 15
        };

        public int Convert(string input)
        {
            var ints = new List<int>();
            double result = 0;

            foreach (var c in input)
            {
                var code = _codes[c.ToString()];
                ints.Add(code);
            }

            ints.Reverse();

            for (var i = 0; i < ints.Count; i++)
            {
                if (ints[i] != 0)
                {
                    result += ints[i] * Math.Pow(Base, i);
                }
            }

            return (int)result;
        }
    }
}
