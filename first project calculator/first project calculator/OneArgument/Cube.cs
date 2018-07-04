namespace first_project_calculator.OneArgument
{
    public class Cube : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument * firstArgument;
        }
    }
}