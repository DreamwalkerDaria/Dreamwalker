using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator
{
    [TestFixture]
    public class CubeTests
    {
        [Test]
        public void CubeCalculatorTests()
        {
            ICalculatorOneArguments calculator = new Cube();
            double actual = calculator.Calculate(2);
            Assert.AreEqual(8, actual);
        }
    }
}