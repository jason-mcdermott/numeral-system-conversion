using System.Collections.Generic;

namespace NumeralSystemConversion.Converters
{
    public class BinaryToHex
    {
        private readonly Dictionary<string, string> _codes = new Dictionary<string, string>
        {
            ["0000"] = "0",
            ["0001"] = "1",
            ["0010"] = "2",
            ["0011"] = "3",
            ["0100"] = "4",
            ["0101"] = "5",
            ["0110"] = "6",
            ["0111"] = "7",
            ["1000"] = "8",
            ["1001"] = "9",
            ["1010"] = "A",
            ["1011"] = "B",
            ["1100"] = "C",
            ["1101"] = "D",
            ["1110"] = "E",
            ["1111"] = "F"
        };

        public string Convert(string input)
        {
            var result = string.Empty;

            var nibbles = GetChunks(input, 4);

            foreach (var nibble in nibbles)
            {
                result += _codes[nibble];
            }

            return result;
        }

        private List<string> GetChunks(string value, int chunkSize)
        {
            var chunks = new List<string>();

            for (int i = 0; i < value.Length; i += chunkSize)
            {
                if (i + chunkSize > value.Length)
                {
                    chunks.Add(value.Substring(i));
                }
                else
                {
                    chunks.Add(value.Substring(i, chunkSize));
                }   
            }   

            return chunks;
        }
    }
}
