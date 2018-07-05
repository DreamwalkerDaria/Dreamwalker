using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation Module.
    /// </summary> 
    public class Module : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}