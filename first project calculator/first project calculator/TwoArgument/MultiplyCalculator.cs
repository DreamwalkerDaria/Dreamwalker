namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Multiply of two arguments.
    /// </summary> 
    public class MultiplyCalculator : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}