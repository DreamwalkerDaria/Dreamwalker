using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Cos();
            double actual = calculator.Calculate(0);
            Assert.AreEqual(1, actual);
        }
    }
}