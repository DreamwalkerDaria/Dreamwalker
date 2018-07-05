namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation Degree.
    /// </summary> 
    public class Degree : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument;
        }
    }
}