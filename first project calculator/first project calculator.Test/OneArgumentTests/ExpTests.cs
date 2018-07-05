using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class ExpTests
    {
        [Test]
        public void ExpCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Exp();
            double actual = calculator.Calculate(1);
            Assert.AreEqual(2.7182818284590451, actual);
        }
    }
}