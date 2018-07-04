using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project_calculator
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
                default:
                throw new Exception("Неизвестная операция");
            }
        }
    }
}
