using System;
namespace first_project_calculator
{
    public class Root : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}