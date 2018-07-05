using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.HardTests
{
    [TestFixture]
    public class RootHardTests
    {
        [TestCase(4, arg2: 2)]
        [TestCase(16, arg2: 4)]
        [TestCase(9, arg2: 3)]
        public void RootCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Root();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}