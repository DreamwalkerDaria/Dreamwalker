namespace first_project_calculator.OneArgument
{
    public class Fraction : ICalculatorOneArguments
    {
        /// <summary>  
        /// fraction calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the fraction of the argument is computed
        /// </param>
        /// <returns>
        /// Return 1/(firstArgument)
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return 1/(firstArgument);
        }
    }
}