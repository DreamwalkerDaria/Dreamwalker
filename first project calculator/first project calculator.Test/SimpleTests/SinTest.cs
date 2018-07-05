using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator
{
    [TestFixture]
    public class SinTests
    {
        [Test]
        public void SinCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Sin();
            double actual = calculator.Calculate(0);
            Assert.AreEqual(0, actual);
        }
    }
}