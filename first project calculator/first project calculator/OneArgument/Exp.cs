using System;

namespace first_project_calculator.OneArgument
{
    public class Exp : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}