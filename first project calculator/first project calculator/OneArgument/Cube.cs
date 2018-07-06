namespace first_project_calculator.OneArgument
{
    public class Cube : ICalculatorOneArguments
    {
        /// <summary>  
        /// cube calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// the cube of the argument is computed
        /// </param>
        /// <returns>
        /// Return Argument^3
        /// </returns>
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument * firstArgument;
        }
    }
}