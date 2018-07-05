using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class LnHardTests
    {
        [TestCase(2, arg2: 0.3010299956639812)]
        [TestCase(10, arg2: 1)]
        [TestCase(4, arg2: 0.6020599913279624)]
        public void LnCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Ln();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}