using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// In hierarchy there will be a static class-factory, responsible for creating instances of calculators by their name.
    /// </summary> 
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
                case "Onedivfarg":
                    return new Onedivfarg();
                case "Minusx":
                    return new Minusx();
                default:
                throw new Exception("Неизвестная операция");
            }
        }
    }
}