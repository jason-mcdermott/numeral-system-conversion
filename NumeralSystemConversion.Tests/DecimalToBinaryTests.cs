using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralSystemConversion.Converters;

namespace NumeralSystemConversion.Tests
{
    [TestClass]
    public class DecimalToBinaryTests
    {
        [TestMethod]
        public void Convert_test_1()
        {
            var dtob = new DecimalToBinary();
            var result = dtob.Convert(4);
            Assert.AreEqual(result, "0100");
        }

        [TestMethod]
        public void Convert_test_2()
        {
            var dtob = new DecimalToBinary();
            var result = dtob.Convert(122);
            Assert.AreEqual(result, "01111010");
        }

        [TestMethod]
        public void Convert_test_3()
        {
            var dtob = new DecimalToBinary();
            var result = dtob.Convert(255);
            Assert.AreEqual(result, "000011111111");
        }

        [TestMethod]
        public void Convert_test_4()
        {
            var dtob = new DecimalToBinary();
            var result = dtob.Convert(4096);
            Assert.AreEqual(result, "0001000000000000");
        }
    }
}
