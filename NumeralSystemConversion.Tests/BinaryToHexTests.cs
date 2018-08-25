using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion.Tests
{
    [TestClass]
    public class BinaryToHexTests
    {
        [TestMethod]
        public void Convert_test_1()
        {
            var btoh = new BinaryToHex();
            var result = btoh.Convert("010001110101");
            Assert.AreEqual(result, "475");
        }

        [TestMethod]
        public void Convert_test_2()
        {
            var btoh = new BinaryToHex();
            var result = btoh.Convert("1111101001011010");
            Assert.AreEqual(result, "FA5A");
        }

        [TestMethod]
        public void Convert_test_3()
        {
            var btoh = new BinaryToHex();
            var result = btoh.Convert("00001111111100101111");
            Assert.AreEqual(result, "0FF2F");
        }

        [TestMethod]
        public void Convert_test_4()
        {
            var btoh = new BinaryToHex();
            var result = btoh.Convert("11001000000000001001");
            Assert.AreEqual(result, "C8009");
        }
    }
}
