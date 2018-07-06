using System;

namespace first_project_calculator.TwoArgument
{ 
    public class Max : ICalculatorTwoArguments
    {
        /// <summary>  
        /// Max calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// double firstArgument
        /// </param>
        /// <param name="secondArgument">
        /// double secondArgument
        /// </param>
        /// <returns>
        /// Return Max(firstArgument, secondArgument)
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Max(firstArgument, secondArgument);
        }
    }
}