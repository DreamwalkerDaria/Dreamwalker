using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class TgHardTests
    {
        [TestCase(2, arg2: -2.1850398632615189)]
        [TestCase(7, arg2: 0.87144798272431878)]
        [TestCase(4, arg2: 1.1578212823495775)]
        public void TgCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Tg();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}