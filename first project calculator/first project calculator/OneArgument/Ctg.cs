using System;

namespace first_project_calculator.OneArgument
{
    public class Ctg : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}