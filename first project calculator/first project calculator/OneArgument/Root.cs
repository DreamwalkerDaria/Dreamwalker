using System;

namespace first_project_calculator.OneArgument
{
    public class Root : ICalculatorOneArguments
    {
        /// <summary>  
        /// root calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the root of the argument is computed
        /// </param>
        /// <returns>
        /// Return sqrt(firstArgument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}