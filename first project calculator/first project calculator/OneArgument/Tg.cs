using System;

namespace first_project_calculator.OneArgument
{
    public class Tg : ICalculatorOneArguments
    {
        /// <summary>  
        /// tg calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the tg of the argument is computed
        /// </param>
        /// <returns>
        /// Return Tan(firstArgument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}