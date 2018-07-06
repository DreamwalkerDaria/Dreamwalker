namespace first_project_calculator.TwoArgument
{  
    public class AdditionCalculator : ICalculatorTwoArguments
    {
        /// <summary>  
        /// Addition calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// double firstArgument
        /// </param>
        /// <param name="secondArgument">
        /// double secondArgument
        /// </param>
        /// <returns>
        /// Return firstArgument + secondArgument
        /// </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}