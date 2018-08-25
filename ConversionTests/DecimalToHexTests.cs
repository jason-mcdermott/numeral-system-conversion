using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeralSystemConversion;

namespace ConversionTests
{
    [TestClass]
    public class DecimalToHexTests
    {
        [TestMethod]
        public void Convert_test_1()
        {
            var dtob = new DecimalToHex();
            var result = dtob.Convert(4);
            Assert.AreEqual(result, "4");
        }

        [TestMethod]
        public void Convert_test_2()
        {
            var dtob = new DecimalToHex();
            var result = dtob.Convert(479);
            Assert.AreEqual(result, "1DF");
        }

        [TestMethod]
        public void Convert_test_3()
        {
            var dtob = new DecimalToHex();
            var result = dtob.Convert(894);
            Assert.AreEqual(result, "37E");
        }

        [TestMethod]
        public void Convert_test_4()
        {
            var dtob = new DecimalToHex();
            var result = dtob.Convert(3284);
            Assert.AreEqual(result, "CD4");
        }
    }
}
