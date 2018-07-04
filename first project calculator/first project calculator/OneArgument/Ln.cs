using System;

namespace first_project_calculator.OneArgument
{
    public class Ln : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}