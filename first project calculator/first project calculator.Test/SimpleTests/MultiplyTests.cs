using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.SimpleTests
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void MultiplyCalculatorTests()
        {
            ICalculatorTwoArguments calculator = new MultiplyCalculator();
            double actual = calculator.Calculate(2, 3);
            Assert.AreEqual(6, actual);
        }
    }
}