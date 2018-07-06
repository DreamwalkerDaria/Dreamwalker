using System;

namespace first_project_calculator.OneArgument
{
    public class Sin : ICalculatorOneArguments
    {
        /// <summary>  
        /// sin calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the sin of the argument is computed
        /// </param>
        /// <returns>
        /// Return sin(firstArgument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}