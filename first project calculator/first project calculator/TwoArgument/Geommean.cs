using System;

namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Addition of two arguments.
    /// </summary>  
    public class Geommean : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Sqrt(firstArgument + secondArgument);
        }
    }
}