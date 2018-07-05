using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class CtgHardTests
    {
        [TestCase(2, arg2: -0.45765755436028577)]
        [TestCase(7, arg2: 1.1475154224051356)]
        [TestCase(4, arg2: 0.86369115445061673)]
        public void CtgCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Ctg();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}