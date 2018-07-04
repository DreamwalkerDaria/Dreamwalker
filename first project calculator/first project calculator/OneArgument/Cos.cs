using System;

namespace first_project_calculator.OneArgument
{
    public class Cos : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}