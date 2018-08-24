using System;
using System.Collections.Generic;

namespace NumeralSystemConversion
{
    public class BinaryToDecimal
    {
        public double Convert(string input)
        {
            var bits = new List<int>();
            double result = 0;

            foreach (var c in input)
            {
                bits.Add(Int32.Parse(c.ToString()));
            }
            
            bits.Reverse();
            
            for (var i = 0; i < bits.Count; i++)
            {
                if (bits[i] != 0)
                {
                    result += Math.Pow(2, i);
                }
            }

            return result;
        }
    }
}
