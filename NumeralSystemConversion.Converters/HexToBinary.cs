using System.Collections.Generic;

namespace NumeralSystemConversion.Converters
{
    public class HexToBinary
    {
        private readonly Dictionary<string, string> _codes = new Dictionary<string, string>
        {
            ["0"] = "0000",
            ["1"] = "0001",
            ["2"] = "0010",
            ["3"] = "0011",
            ["4"] = "0100",
            ["5"] = "0101",
            ["6"] = "0110",
            ["7"] = "0111",
            ["8"] = "1000",
            ["9"] = "1001",
            ["A"] = "1010",
            ["B"] = "1011",
            ["C"] = "1100",
            ["D"] = "1101",
            ["E"] = "1110",
            ["F"] = "1111"
        };

        public string Convert(string input)
        {
            var bits = new List<string>();
            
            foreach (var c in input)
            {
                var code = _codes[c.ToString()];
                bits.Add(code);
            }
            
            return string.Join("", bits);
        }
    }
}
