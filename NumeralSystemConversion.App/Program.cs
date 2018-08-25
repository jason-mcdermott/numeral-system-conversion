using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var htob = new HexToBinary();
            var result = htob.Convert("3AB2");
        }
    }
}
