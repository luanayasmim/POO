using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p1 = new Pessoa("Miguel", 20, "M");
            Visitante v1= new Visitante("Miguel", 20, "M");
            Aluno a1 = new Aluno("Luana", 18, "F", 0001, "DS");
            Bolsista b1 = new Bolsista("Caio", 19, "M", 0002, "ADM");
            Professor p1 = new Professor("Vitória", 30, "F", "Programação Web", 3000);
            Funcionario f1 = new Funcionario("Kaique", 33, "M", "RH", true);

            a1.PagarMensalidade();
            b1.PagarMensalidade();
        }
    }
}
