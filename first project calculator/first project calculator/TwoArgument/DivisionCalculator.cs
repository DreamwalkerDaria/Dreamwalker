using System;

namespace first_project_calculator.TwoArgument
{
    public class DivisionCalculator : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Деление на 0");
            }
            return firstArgument / secondArgument;
        }
    }
}