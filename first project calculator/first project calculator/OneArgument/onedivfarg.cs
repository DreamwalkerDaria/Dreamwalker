using System;

namespace first_project_calculator.OneArgument
{
    /// <summary>  
    /// Operation one vidision on first argument.
    /// </summary> 
    public class Onedivfarg : ICalculatorOneArguments
    {
        public double Calculate(double firstArgument)
        {
            return 1/(firstArgument);
        }
    }
}