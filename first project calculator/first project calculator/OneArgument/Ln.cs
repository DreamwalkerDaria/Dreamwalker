using System;

namespace first_project_calculator.OneArgument
{
    public class Ln : ICalculatorOneArguments
    {
        /// <summary>  
        /// lg calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the lg of the argument is computed
        /// </param>
        /// <returns>
        /// Return 1/(firstArgument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Log10(firstArgument);
        }
    }
}