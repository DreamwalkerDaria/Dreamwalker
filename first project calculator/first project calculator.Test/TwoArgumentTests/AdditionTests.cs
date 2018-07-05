using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.TwoArgumentTests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void AdditionCalculatorTests()
        {
            ICalculatorTwoArguments calculator = new AdditionCalculator();
            double actual = calculator.Calculate(2, 2);
            Assert.AreEqual(4, actual);
        }
    }
}