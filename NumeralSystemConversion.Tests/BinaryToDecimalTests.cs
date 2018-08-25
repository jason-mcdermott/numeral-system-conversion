using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion.Tests
{
    [TestClass]
    public class BinaryToDecimalTests
    {
        [TestMethod]
        public void Convert_test_1()
        {
            var btod = new BinaryToDecimal();
            var result = btod.Convert("0100");
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void Convert_test_2()
        {
            var btod = new BinaryToDecimal();
            var result = btod.Convert("01111010");
            Assert.AreEqual(result, 122);
        }

        [TestMethod]
        public void Convert_test_3()
        {
            var btod = new BinaryToDecimal();
            var result = btod.Convert("000011111111");
            Assert.AreEqual(result, 255);
        }

        [TestMethod]
        public void Convert_test_4()
        {
            var btod = new BinaryToDecimal();
            var result = btod.Convert("0001000000000000");
            Assert.AreEqual(result, 4096);
        }
    }
}
