using System;

namespace first_project_calculator.TwoArgument
{
    public class Geommean : ICalculatorTwoArguments
    {
        /// <summary>  
        /// Geometric mean calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// double firstArgument
        /// </param>
        /// <param name="secondArgument">
        /// double secondArgument
        /// </param>
        /// <returns>
        /// Return Sqrt(firstArgument + secondArgument)
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Sqrt(firstArgument + secondArgument);
        }
    }
}