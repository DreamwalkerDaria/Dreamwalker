﻿using System;
using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.TwoArgumentTests
{
    [TestFixture]
    public class DivisionHardTests
    {
        [TestCase(10, 2, 5)]
        [TestCase(8, 4, 2)]
        [TestCase(9, 3, 3)]
        public void DivisionCalculatorTests(double firstArgument, double secondArgument, double result)
        {
            var calculator = new DivisionCalculator();
            var actualResult = calculator.Calculate(firstArgument, secondArgument);
            Assert.AreEqual(result, actualResult);
        }

        [Test]
        public void DivisionExeptionTest()
        {
            ICalculatorTwoArguments calculator = CalculateTwoFactory.CreateCalculator("Division");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}
