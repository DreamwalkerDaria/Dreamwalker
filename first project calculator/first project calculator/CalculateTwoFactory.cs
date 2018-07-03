using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project_calculator
{
    class CalculateTwoFactory
    {
        public static ICalculatorTwoArguments CreateCalculator(string calculatorName)
        {
            switch(calculatorName)
            {
                case "ButtonAddition":
                    return new AdditionCalculator();
                case "ButtonSubtraction":
                    return new SubtractionCalculator();
                case "ButtonMultiply":
                    return new MultiplyCalculator();
                case "ButtonDivision":
                    return new DivisionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
