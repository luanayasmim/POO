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

            void CalcularBonificacao()
            {
                GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

                Contador yasmim = new Contador("1234567890");
                yasmim.Nome = "Yasmim";

                Diretor luana = new Diretor("123456789");
                luana.Nome = "Luana";

                Funcionario ricardo = new Diretor("123456789-p");
                ricardo.Nome = "Ricardo";

                gerenciador.Registrar(yasmim);
                gerenciador.Registrar(luana);
                gerenciador.Registrar(ricardo);


                Console.WriteLine($"Novo salário da Yasmim: {yasmim.Salario}");
                Console.WriteLine($"Novo salário da Luana: {luana.Salario}");
                Console.WriteLine($"Novo salário da Ricardo: {ricardo.Salario}");

                Console.WriteLine();

                Console.WriteLine($"A empresa tem {Funcionario.TotalFuncionarios} funcionários!");
            }

            CalcularBonificacao();

           /*GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            double totalBonificacao;

            Funcionario yasmim = new Funcionario("1234567890", 1000);
            yasmim.Nome = "Yasmim";
            //yasmim.Cpf = ;
            //yasmim.Salario = 1000;
            yasmim.AumentarSalario();
            Console.WriteLine($"Novo salário da Yasmim: {yasmim.Salario}");

            //Conferindo funcionários cadastrados na empresa
            Console.WriteLine($"A empresa tem {Funcionario.TotalFuncionarios} funcionários!");


            Diretor luana = new Diretor("123456789");
            luana.Nome = "Luana";
            //luana.Cpf = "123456789";
            //luana.Salario = 2000;
            luana.AumentarSalario();
            Console.WriteLine($"Novo salário da Luana: {luana.Salario}");

            //Conferindo funcionários cadastrados na empresa
            Console.WriteLine($"A empresa tem {Funcionario.TotalFuncionarios} funcionários!");

            gerenciador.Registrar(yasmim);
            gerenciador.Registrar(luana);

            Console.WriteLine($"Bonificação: {yasmim.getBonificacao()}");
            Console.WriteLine($"Bonificação: {luana.getBonificacao()}");

            totalBonificacao = luana.getBonificacao();
            totalBonificacao += yasmim.getBonificacao();

            Console.WriteLine("Total do Bonificações: " + gerenciador.getBonificacao());

            Funcionario ricardo = new Diretor("123456789-p");
            ricardo.Nome = "Ricardo";
            Console.WriteLine(ricardo.Nome);
            //Conferindo funcionários cadastrados na empresa
            Console.WriteLine($"A empresa tem {Funcionario.TotalFuncionarios} funcionários!");*/
        }
    }
}
