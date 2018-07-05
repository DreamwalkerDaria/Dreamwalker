using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class ModuleTests
    {
        [Test]
        public void ModuleCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Module();
            double actual = calculator.Calculate(-2);
            Assert.AreEqual(2, actual);
        }
    }
}