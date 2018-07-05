using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class RootTests
    {
        [Test]
        public void RootCalculationTest()
        {
            ICalculatorOneArguments calculator = new Root();
            double actual = calculator.Calculate(4);
            Assert.AreEqual(2, actual);
        }
    }
}