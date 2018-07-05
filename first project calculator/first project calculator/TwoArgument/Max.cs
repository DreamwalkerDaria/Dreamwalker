using System;

namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Addition of two arguments.
    /// </summary>  
    public class Max : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}