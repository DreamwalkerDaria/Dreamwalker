using System;

namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// In hierarchy there will be a static class-factory, responsible for creating instances of calculators by their name.
    /// </summary> 
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
                case "Max":
                    return new Max();
                case "Min":
                    return new Min();
                case "Average":
                    return new Average();
                case "Geommean":
                    return new Geommean();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}