using System;

namespace first_project_calculator.OneArgument
{
    public class Module : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}