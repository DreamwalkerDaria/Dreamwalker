using System;

namespace first_project_calculator.TwoArgument
{
    /// <summary>  
    /// Division of two arguments.
    /// </summary> 
    public class DivisionCalculator : ICalculatorTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Error! Division by zero");
            }
            return firstArgument / secondArgument;
        }
        }
    }