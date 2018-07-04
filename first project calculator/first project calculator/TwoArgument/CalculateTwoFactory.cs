using System;



namespace first_project_calculator
{
    class CalculateTwoFactory
    {
        public static ICalculatorTwoArguments CreateCalculator(string calculatorName)
        {
            switch(calculatorName)
            {
                case "Addition":
                    return new AdditionCalculator();
                case "Subtraction":
                    return new SubtractionCalculator();
                case "Multiply":
                    return new MultiplyCalculator();
                case "Division":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
