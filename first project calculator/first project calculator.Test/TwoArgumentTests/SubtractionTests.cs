using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.TwoArgumentTests
{
    [TestFixture]
    public class SubtractionTests
    {
        [Test]
        public void SubtractionCalculatorTests()
        {
            ICalculatorTwoArguments calculator = new SubtractionCalculator();
            double actual = calculator.Calculate(2, 2);
            Assert.AreEqual(0, actual);
        }
    }
}