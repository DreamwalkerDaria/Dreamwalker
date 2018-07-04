namespace first_project_calculator.TwoArgument
{
    public class AdditionCalculator : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}