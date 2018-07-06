using System;

namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Min calculator function
    /// </summary>
    /// <param name="firstArgument">
    /// double firstArgument
    /// </param>
    /// <param name="secondArgument">
    /// double secondArgument
    /// </param>
    /// <returns>
    /// Return Min(firstArgument, secondArgument)
    /// </returns> 
    public class Min : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Min(firstArgument, secondArgument);
        }
    }
}