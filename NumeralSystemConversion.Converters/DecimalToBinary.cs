using System.Collections.Generic;
using System.Linq;

namespace NumeralSystemConversion.Converters
{
    public class DecimalToBinary
    {
        public string Convert(int input)
        {
            // empty list that will hold the 1's and 0's
            var output = new List<int>();

            // set up list of binary series
            var binaryList = new List<int> { 1 };

            var end = binaryList.Last();

            while (input > end)
            {
                var next = end * 2;
                binaryList.Add(next);
                end = binaryList.Last();
            }

            // sort so largest number is on the left
            binaryList.Reverse();

            var compareTo = input;

            foreach (var b in binaryList)
            {
                if (b <= compareTo)
                {
                    output.Add(1);
                    compareTo = compareTo - b;
                }
                else
                {
                    output.Add(0);
                }
            }

            // pad with zero's 
            while(output.Count % 4 != 0)
            {
                output.Insert(0, 0);
            }

            return string.Join("", output);
        }
    }
}
