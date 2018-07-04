using System;

namespace first_project_calculator.OneArgument
{
    public class Tg : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}