namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Subraction of two arguments.
    /// </summary> 
    public class SubtractionCalculator : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
}