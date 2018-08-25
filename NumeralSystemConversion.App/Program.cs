using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var htod = new HexToDecimal();
            var result = htod.Convert("C9");
        }
    }
}
