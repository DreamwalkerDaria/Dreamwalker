using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class ModuleHardTests
    {
        [TestCase(2, arg2: 2)]
        [TestCase(-4, arg2: 4)]
        [TestCase(-9, arg2: 9)]
        public void ModuleCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Module();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}