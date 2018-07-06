namespace first_project_calculator.OneArgument
{
    public class Degree : ICalculatorOneArguments
    {
        /// <summary>  
        /// degree calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the degree of the argument is computed
        /// </param>
        /// <returns>
        /// Return degree of Argument
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument;
        }
    }
}