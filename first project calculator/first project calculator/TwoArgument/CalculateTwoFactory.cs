using System;

namespace first_project_calculator.TwoArgument
{
   public class CalculateTwoFactory
    {
        /// <summary>
        /// Method based on name button
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns>
        /// calculatorname
        /// </returns>
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