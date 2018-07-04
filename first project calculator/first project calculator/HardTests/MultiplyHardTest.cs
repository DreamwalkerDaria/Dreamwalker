using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class MultiplyHardTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(8, 4, 32)]
        [TestCase(9, 3, 27)]
        public void MultiplyCalculatorTests(double firstArgument, double secondArgument, double result)
        {
            var calculator = new MultiplyCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}
