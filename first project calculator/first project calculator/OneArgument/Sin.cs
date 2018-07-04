using System;

namespace first_project_calculator.OneArgument
{
    public class Sin : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}