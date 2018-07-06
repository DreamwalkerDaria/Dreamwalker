using System;

namespace first_project_calculator.OneArgument
{
    public class Minusx : ICalculatorOneArguments
    {
        /// <summary>  
        /// minusx calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the negation of the number of the argument is computed
        /// </param>
        /// <returns>
        /// Return -firstArgument
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return -firstArgument;
        }
    }
}