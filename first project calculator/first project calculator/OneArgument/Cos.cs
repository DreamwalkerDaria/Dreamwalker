using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation Cos.
    /// </summary> 
    public class Cos : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}