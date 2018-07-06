namespace first_project_calculator.TwoArgument
{ 
    public class Average : ICalculatorTwoArguments
    {
        /// <summary>  
        /// Average calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// double firstArgument
        /// </param>
        /// <param name="secondArgument">
        /// double secondArgument
        /// </param>
        /// <returns>
        /// Return (firstArgument + secondArgument)/2
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument)/2;
        }
    }
}