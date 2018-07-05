using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.TwoArgumentTests
{
    [TestFixture]
    public class AdditionHardTests
    {
        [TestCase(6, 2, 8)]
        [TestCase(8, 4, 12)]
        [TestCase(9, 3, 12)]
        public void AdditionCalculatorTests(double firstArgument, double secondArgument, double result)
        {
            var calculator = new AdditionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}
