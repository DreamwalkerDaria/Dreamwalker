using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator
{
    [TestFixture]
    public class TgTests
    {
        [Test]
        public void TgCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Tg();
            double actual = calculator.Calculate(2);
            Assert.AreEqual(-2.1850398632615189, actual);
        }
    }
}