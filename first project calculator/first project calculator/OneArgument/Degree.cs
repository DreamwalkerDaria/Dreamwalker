namespace first_project_calculator.OneArgument
{
    public class Degree : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument;
        }
    }
}