using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorClasses.Operacoes
{
    public class Subtracao
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Subtrair()
        {
            return num1 - num2;
        }

    }
}
