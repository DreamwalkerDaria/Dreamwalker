using System;

namespace first_project_calculator.OneArgument
{
    public class Ctg : ICalculatorOneArguments
    {
        /// <summary>  
        /// ctg calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the ctg of the argument is computed
        /// </param>
        /// <returns>
        /// Return ctg(Argument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}