using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorClasses.Operacoes
{
    public class Multiplicacao
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Multiplicar()
        {
            return num1 * num2;
        }
    }
}
