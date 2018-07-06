using System;

namespace first_project_calculator.TwoArgument
{
    public class DivisionCalculator : ICalculatorTwoArguments
    {
        /// <summary>  
        /// Division calculator function
        /// </summary>
        /// <param name="firstArgument">
        /// double firstArgument
        /// </param>
        /// <param name="secondArgument">
        /// double secondArgument
        /// </param>
        /// <returns>
        /// Return firstArgument / secondArgument
        /// </returns>
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