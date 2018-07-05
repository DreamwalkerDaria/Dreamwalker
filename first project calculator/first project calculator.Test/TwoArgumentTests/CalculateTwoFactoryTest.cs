using System;
using first_project_calculator.TwoArgument;
using NUnit.Framework;

namespace first_project_calculator.Test.TwoArgumentTests
{
    public class CalculatorTwoArgumentsTests
    {
        [TestCase("Addition", typeof(AdditionCalculator))]
        [TestCase("Subtraction", typeof(SubtractionCalculator))]
        [TestCase("Multiply", typeof(MultiplyCalculator))]
        [TestCase("Division", typeof(DivisionCalculator))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = CalculateTwoFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}