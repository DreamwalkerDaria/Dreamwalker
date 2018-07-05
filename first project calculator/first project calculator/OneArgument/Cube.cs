namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation Cube.
    /// </summary> 
    public class Cube : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument * firstArgument;
        }
    }
}