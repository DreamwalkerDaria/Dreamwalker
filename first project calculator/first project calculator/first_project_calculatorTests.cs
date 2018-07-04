using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_project_calculator;
using NUnit.Framework;

namespace first_project_calculatorTests.CalculateOneArgumentsTest
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
