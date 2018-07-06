using System;

namespace first_project_calculator.OneArgument
{
    public class Module : ICalculatorOneArguments
    {
        /// <summary>  
        /// mmodule calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the module of the argument is computed
        /// </param>
        /// <returns>
        /// Return Abs(firstArgument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}