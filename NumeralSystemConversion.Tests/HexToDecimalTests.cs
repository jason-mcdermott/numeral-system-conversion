using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion.Tests
{
    [TestClass]
    public class HexToDecimalTests
    {
        [TestMethod]
        public void Convert_test_1()
        {
            var htod = new HexToDecimal();
            var result = htod.Convert("AF");
            Assert.AreEqual(result, 175);
        }

        [TestMethod]
        public void Convert_test_2()
        {
            var htod = new HexToDecimal();
            var result = htod.Convert("ACD");
            Assert.AreEqual(result, 2765);
        }

        [TestMethod]
        public void Convert_test_3()
        {
            var htod = new HexToDecimal();
            var result = htod.Convert("AB2");
            Assert.AreEqual(result, 2738);
        }

        [TestMethod]
        public void Convert_test_4()
        {
            var htod = new HexToDecimal();
            var result = htod.Convert("FF");
            Assert.AreEqual(result, 255);
        }
    }
}
