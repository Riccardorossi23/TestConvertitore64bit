using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassBase64;
    
namespace TestConvertitore64bit
{
    [TestClass]
    public class TestBase64
    {
        [TestMethod]
        public static void Testbase64()
        {
            string r = Base64.Base64();
            Assert.AreEqual("UmljY2FyZG8=", r);
        }
    }
}