using FirstApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFraction.UnitTests
{
    [TestClass]
    public class FractionTests
    {
        [TestMethod]
        public void NumbericRepresentation_NumberToOnePlace_ReturnsNumberToOnePlace()
        {
            var fraction = new Fraction(1, 2);

            var result = fraction.NumbericRepresentation(1);

            Assert.AreEqual(result, 0.5);
        }
    }
}
