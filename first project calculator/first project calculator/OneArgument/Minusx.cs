using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation one vidision on first argument.
    /// </summary> 
    public class Minusx : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return -firstArgument;
        }
    }
}