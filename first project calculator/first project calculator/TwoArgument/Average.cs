namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Addition of two arguments.
    /// </summary>  
    public class Average : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return (firstArgument + secondArgument)/2;
        }
    }
}