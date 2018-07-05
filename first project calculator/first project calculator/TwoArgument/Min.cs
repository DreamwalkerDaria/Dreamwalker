using System;

namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Addition of two arguments.
    /// </summary>  
    public class Min : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}