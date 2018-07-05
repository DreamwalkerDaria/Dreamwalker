using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class LnTests
    {
        [Test]
        public void LnCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Ln();
            double actual = calculator.Calculate(1);
            Assert.AreEqual(0, actual);
        }
    }
}