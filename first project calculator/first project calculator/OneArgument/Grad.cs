using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation one vidision on first argument.
    /// </summary> 
    public class Grad : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument) * 180 / Math.PI;
        }
    }
}