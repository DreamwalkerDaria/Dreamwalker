using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class DegreeHardTests
    {
        [TestCase(2, arg2: 4)]
        [TestCase(7, arg2: 49)]
        [TestCase(4, arg2: 16)]
        public void DegreeCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Degree();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}