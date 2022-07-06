using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorClasses.Operacoes
{
    public class Divisao
    {
        public double num1 { get; set; }
        public double num2 { get; set; }

        public double Dividir()
        {
            return num1 / num2;
        }
    }
}
