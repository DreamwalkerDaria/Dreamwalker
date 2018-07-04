using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class CosHardTests
    {
        [TestCase(3, arg2: -0.98999249660044542)]
        [TestCase(8, arg2: -0.14550003380861354)]
        [TestCase(9, arg2: -0.91113026188467694)]
        public void CosCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Cos();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}