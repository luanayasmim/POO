using System;
using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitarios;

namespace bytebank_adm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BYTEBANK ADMINISTRAÇÃO");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            double totalBonificacao;

            Funcionario yasmim = new Funcionario(1);
            yasmim.Nome = "Yasmim";
            yasmim.Cpf = "1234567890";
            yasmim.Salario = 1;


            Diretor luana = new Diretor();
            luana.Nome = "Luana";
            luana.Cpf = "123456789";
            luana.Salario = 10;

            gerenciador.Registrar(yasmim);
            gerenciador.Registrar(luana);

            Console.WriteLine($"Bonificação: {yasmim.getBonificacao()}");
            Console.WriteLine($"Bonificação: {luana.getBonificacao()}");

            totalBonificacao = luana.getBonificacao();
            totalBonificacao += yasmim.getBonificacao();

            Console.WriteLine("Total do Bonificações: " + gerenciador.getBonificacao());
        }
    }
}
