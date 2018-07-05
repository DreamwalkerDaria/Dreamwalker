using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.OneArgumentTests
{
    [TestFixture]
    public class CtgTests
    {
        [Test]
        public void CtgCalculatorTest()
        {
            ICalculatorOneArguments calculator = new Ctg();
            double actual = calculator.Calculate(2);
            Assert.AreEqual(-0.45765755436028577, actual);
        }
    }
}