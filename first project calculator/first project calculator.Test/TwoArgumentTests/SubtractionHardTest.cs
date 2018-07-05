using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class SubtractionHardTests
    {
        [TestCase(6, 2, 4)]
        [TestCase(8, 4, 4)]
        [TestCase(9, 3, 6)]
        public void SubtractionCalculatorTests(double firstArgument, double secondArgument, double result)
        {
            var calculator = new SubtractionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}