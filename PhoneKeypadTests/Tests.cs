using Microsoft.VisualStudio.TestTools.UnitTesting;
using PhoneKeypadLib;

namespace PhoneKeypadTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Translate_SingleDigit()
        {
            Assert.AreEqual("T", PhoneKeypad.Translate("8"));
        }

        [TestMethod]
        public void Translate_MultipleDigit()
        {
            Assert.AreEqual("Z", PhoneKeypad.Translate("9999"));
        }

        [TestMethod]
        public void Translate_MixedInputWithLetters()
        {
            string input = "P444777666a667777666333A892777n33";
            Assert.AreEqual("IRONSOFTWARE", PhoneKeypad.Translate(input));
        }

        [TestMethod]
        public void Translate_MixedInputWithAll()
        {
            string input = "44 4*444@044460&92466ABC33/777#99955";
            Assert.AreEqual("HI IM WAGNER", PhoneKeypad.Translate(input));
        }
    }
}
