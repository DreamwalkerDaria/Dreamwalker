using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.TwoArgumentTests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisionCalculatorTests()
        {
            ICalculatorTwoArguments calculator = new DivisionCalculator();
            double actual = calculator.Calculate(2, 2);
            Assert.AreEqual(1, actual);
        }
    }
}