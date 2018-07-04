using System;
using first_project_calculator.OneArgument;
using NUnit.Framework;

namespace first_project_calculator.ArgumentsTests
{
    public class CalculatorOneArgumentsTests
    {
        [TestCase("Degree", typeof(Degree))]
        [TestCase("Root", typeof(Root))]
        [TestCase("Cube", typeof(Cube))]
        [TestCase("Sin", typeof(Sin))]
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Tg", typeof(Tg))]
        [TestCase("Ctg", typeof(Ctg))]
        [TestCase("Module", typeof(Module))]
        [TestCase("Ln", typeof(Ln))]
        [TestCase("Exp", typeof(Exp))]
        public void CalculateTest(string name, Type type)
        {
            var calculator = CalculateOneFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}