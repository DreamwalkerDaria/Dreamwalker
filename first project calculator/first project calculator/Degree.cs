﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project_calculator
{
    public class Degree : ICalculatorOneArguments
    {
        public double Calculate(double firstValue)
        {
            return firstValue * firstValue;
        }
    }
}