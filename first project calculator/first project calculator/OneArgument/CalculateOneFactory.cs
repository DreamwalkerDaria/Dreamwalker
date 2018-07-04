using System;

namespace first_project_calculator.OneArgument
{
    class CalculateOneFactory
    {
        public static ICalculatorOneArguments CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Degree":
                    return new Degree();
                case "Root":
                    return new Root();
                case "Cube":
                    return new Cube();
                case "Sin":
                    return new Sin();
                case "Cos":
                    return new Cos();
                case "Tg":
                    return new Tg();
                case "Ctg":
                    return new Ctg();
                case "Module":
                    return new Module();
                case "Ln":
                    return new Ln();
                case "Exp":
                    return new Exp();
                default:
                throw new Exception("Неизвестная операция");
            }
        }
    }
}