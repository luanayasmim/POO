using System;
using bytebank_adm.Funcionarios;
using bytebank_adm.Utilitarios;
using bytebank_adm.SistemaInterno.SistemaInterno;

namespace bytebank_adm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BYTEBANK ADMINISTRAÇÃO");

            Console.WriteLine("### Usando o sistema ###");
            UsarSistema();

            Console.WriteLine("\n");

            Console.WriteLine("### Calculando Bonificação ###");
            CalcularBonificacao();

            Console.ReadKey();

            static void UsarSistema()
            {
                SistemaInterno sistemaInterno = new SistemaInterno();

                Diretor samya = new Diretor("159.753.398-04");
                samya.Nome = "Sâmya";
                samya.Senha = "asd";

                GerenteDeConta brenda = new GerenteDeConta("326.985.628-89");
                brenda.Nome = "Brenda";
                brenda.Senha = "qwe";

                ParceiroComercial parceiro = new ParceiroComercial();
                parceiro.Senha = "123456";

                sistemaInterno.Logar(parceiro, "123456");

                sistemaInterno.Logar(samya, "asd");
                sistemaInterno.Logar(brenda, "qwe");
            }


            static void CalcularBonificacao()
            {
                GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

                Funcionario pedro = new Designer("833.222.048-39");
                pedro.Nome = "Pedro";

                Funcionario roberta = new Diretor("159.753.398-04");
                roberta.Nome = "Roberta";

                Funcionario igor = new Auxiliar("981.198.778-53");
                igor.Nome = "Igor";

                Funcionario camila = new GerenteDeConta("326.985.628-89");
                camila.Nome = "Camila";

                Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
                guilherme.Nome = "Guilherme";

                gerenciadorBonificacao.Registrar(guilherme);
                gerenciadorBonificacao.Registrar(pedro);
                gerenciadorBonificacao.Registrar(roberta);
                gerenciadorBonificacao.Registrar(igor);
                gerenciadorBonificacao.Registrar(camila);

                Console.WriteLine("Total de bonificações do mês " +
                    gerenciadorBonificacao.GetTotalBonificacao());
            }

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
