namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Addition of two arguments.
    /// </summary>  
    public class AdditionCalculator : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}