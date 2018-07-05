using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation Root.
    /// </summary> 
    public class Root : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sqrt(firstArgument);
        }
    }
}