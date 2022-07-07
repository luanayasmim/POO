using CalculatorClasses.Operacoes;
using System;

namespace CalculatorClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            //Definindo novo objeto a partir da classe Soma
            Soma soma1 = new Soma();
            //Atribuindo valores aos atributos do objeto
            soma1.num1 = 9;
            soma1.num2 = 10;
            //Invocando o Metodo que realiza a lógica da soma com os números informados anteriormente
            Console.WriteLine(soma1.Somar());

            Subtracao subtracao1 = new Subtracao();
            subtracao1.num1 = 10;
            subtracao1.num2 = 6;
            Console.WriteLine(subtracao1.Subtrair());

            Multiplicacao multiplicacao1 = new Multiplicacao();
            multiplicacao1.num1 = 10;
            multiplicacao1.num2 = 2;
            Console.WriteLine(multiplicacao1.Multiplicar());

            Divisao divisao1 = new Divisao();
            divisao1.num1 = 20;
            divisao1.num2 = 5;
            Console.WriteLine(divisao1.Dividir());

        }
    }
}
