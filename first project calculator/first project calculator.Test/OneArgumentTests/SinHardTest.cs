using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class SinHardTests
    {
        [TestCase(3, arg2: 0.14112000805986721)]
        [TestCase(8, arg2: 0.98935824662338179)]
        [TestCase(9, arg2: 0.41211848524175659)]
        public void SinCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Sin();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}