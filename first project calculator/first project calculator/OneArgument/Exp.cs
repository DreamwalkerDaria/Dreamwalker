using System;

namespace first_project_calculator.OneArgument
{
    public class Exp : ICalculatorOneArguments
    {
        /// <summary>  
        /// exp calculator function
        /// </summary>
        /// <param name="argument">
        /// the exp of the argument is computed
        /// </param>
        /// <returns>
        /// Return exp(Argument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}