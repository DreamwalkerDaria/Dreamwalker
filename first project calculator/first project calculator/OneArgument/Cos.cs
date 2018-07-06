using System;

namespace first_project_calculator.OneArgument
{
    public class Cos : ICalculatorOneArguments
    {
        /// <summary>  
        /// cos calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the cosine of the argument is computed
        /// </param>
        /// <returns>
        /// Return Cos(Argument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}