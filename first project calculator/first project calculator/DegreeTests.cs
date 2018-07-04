using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator
{
[TestFixture]
    public class DegreeTests
    { [Test]
	public void DergeeTests()
	{
	ICalculatorOneArguments calculator = new Degree();
	double actual = calculator.Calculate(2);
	Assert.AreEqual(4,actual );
	}
    }
}
