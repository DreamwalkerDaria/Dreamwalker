namespace first_project_calculator
{
    public class Degree : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return firstArgument * firstArgument;
        }
    }
}
