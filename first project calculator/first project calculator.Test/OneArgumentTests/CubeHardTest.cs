using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class CubeHardTests
    {
        [TestCase(2, arg2: 8)]
        [TestCase(4, arg2: 64)]
        [TestCase(5, arg2: 125)]
        public void CubeCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Cube();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}