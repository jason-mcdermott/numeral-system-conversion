using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion.Tests
{
    [TestClass]
    public class HexToBinaryTests
    {
        [TestMethod]
        public void Convert_test_1()
        {
            var htob = new HexToBinary();
            var result = htob.Convert("3AB2");
            Assert.AreEqual(result, "0011101010110010");
        }

        [TestMethod]
        public void Convert_test_2()
        {
            var htob = new HexToBinary();
            var result = htob.Convert("1F9B");
            Assert.AreEqual(result, "0001111110011011");
        }

        [TestMethod]
        public void Convert_test_3()
        {
            var htob = new HexToBinary();
            var result = htob.Convert("56DF");
            Assert.AreEqual(result, "0101011011011111");
        }

        [TestMethod]
        public void Convert_test_4()
        {
            var htob = new HexToBinary();
            var result = htob.Convert("FABF");
            Assert.AreEqual(result, "1111101010111111");
        }
    }
}
