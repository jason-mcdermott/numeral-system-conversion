
namespace NumeralSystemConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dtob = new DecimalToBinary();
            var result = dtob.Convert(255);

            var btod = new BinaryToDecimal();
            var result2 = btod.Convert("1010");
        }
    }
}
