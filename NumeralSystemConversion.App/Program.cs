using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var btoh = new BinaryToHex();
            var result = btoh.Convert("00011111011101110010");
        }
    }
}
