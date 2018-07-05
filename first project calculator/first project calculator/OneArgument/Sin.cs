using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation Sin.
    /// </summary> 
    public class Sin : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}