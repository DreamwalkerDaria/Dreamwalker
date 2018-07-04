using System;

namespace first_project_calculator.OneArgument
{
    public class Root : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}