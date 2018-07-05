using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class ExpHardTests
    {
        [TestCase(2, arg2: 7.38905609893065)]
        [TestCase(10, arg2: 22026.465794806718)]
        [TestCase(4, arg2: 54.598150033144236)]
        public void ExpCalculatorTests(double firstArgument, double result)
        {
            var calculator = new Exp();
            var actualResult = calculator.Calculate(firstArgument);
            Assert.AreEqual(result, actualResult);
        }
    }
}