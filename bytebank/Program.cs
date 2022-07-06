using System;
using bytebank;
using bytebank.Titular;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) ao banco ByteBank!");

            Cliente luana = new Cliente();
            luana.Nome = "Luana Yasmim";
            ContaCorrente conta1 = new ContaCorrente(123, "09876-x");
            conta1.Saldo = 100;
            conta1.Titular = luana;
            Console.WriteLine(conta1.Titular.Nome);
            Console.WriteLine(conta1.Saldo);
            Console.WriteLine(conta1.NumeroAgencia);
            Console.WriteLine(conta1.Conta);

            ContaCorrente conta2 = new ContaCorrente(321, "45678-l");

            ContaCorrente conta3 = new ContaCorrente(987, "87654-y");

            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Console.ReadKey();

            /*
            //Definição da variável 
             ContaCorrente conta1 = new ContaCorrente();
            //Atribuição dos valores
             conta1.titular = "Luana Yasmim";
             conta1.conta = "12345-y";
             conta1.numeroAgencia = 20;
             conta1.nomeAgencia = "CentralByte";
             conta1.saldo = 0.00;
             conta1.ativo = true;

            //Definição da variável
             ContaCorrente conta2 = new ContaCorrente();
            //Atribuição dos valores
             conta2.titular = "Fernanda";
             conta2.conta = "54321-0";
             conta2.numeroAgencia = 20;
             conta2.nomeAgencia = "CentralByte";
             conta2.saldo = 100;
             conta2.ativo = true;

             //Definição da variável
             ContaCorrente conta3 = new ContaCorrente();
            conta3.titular = "Luana Yasmim";
            conta3.conta = "12345-y";
            conta3.numeroAgencia = 20;
            conta3.nomeAgencia = "CentralByte";
            conta3.saldo = 0.00;
            conta3.ativo = true;


            Console.WriteLine($@"Titular: {conta1.titular}
 Conta: {conta1.conta}
 Número da Agencia: {conta1.numeroAgencia}
 Nome da Agencia: {conta1.nomeAgencia}
 Saldo: R$ {String.Format("{0:0.00}", conta1.saldo)}
 Status da Conta: {conta1.ativo}");
             Console.WriteLine();
             Console.WriteLine($@"Titular: {conta2.titular}
 Conta: {conta2.conta}
 Número da Agencia: {conta2.numeroAgencia}
 Nome da Agencia: {conta2.nomeAgencia}
 Saldo: R$ {String.Format("{0:0.00}", conta2.saldo)}
 Status da Conta: {conta2.ativo}");
             Console.WriteLine();
             Console.WriteLine($@"Titular: {conta3.titular}
 Conta: {conta3.conta}
 Número da Agencia: {conta3.numeroAgencia}
 Nome da Agencia: {conta3.nomeAgencia}
 {String.Format("{0:0.00}", conta3.saldo)}
 Status da Conta: {conta3.ativo}");



            //Console.WriteLine(conta1 == conta3);

            //Exemplo de Saque
            Console.WriteLine($@"O Saldo antes do saque era: R${String.Format("{0:0.00}", conta2.saldo)}");
            conta2.Sacar(5);
            Console.WriteLine($@"O Saldo atual é: R${String.Format("{0:0.00}", conta2.saldo)}");

            //Exemplo de Deposito
            Console.WriteLine($@"O Saldo antes do deposito era: R${String.Format("{0:0.00}", conta1.saldo)}");
            conta1.Depositar(1000);
            Console.WriteLine($@"O Saldo atual é: R${String.Format("{0:0.00}", conta1.saldo)}");

            Console.WriteLine($@"Conta 1: R${String.Format("{0:0.00}", conta1.saldo)}");
            Console.WriteLine($@"Conta 2: R${String.Format("{0:0.00}", conta2.saldo)}");
            conta1.Transferir(90, conta2);
            Console.WriteLine($@"Conta 1: R${String.Format("{0:0.00}", conta1.saldo)}");
            Console.WriteLine($@"Conta 2: R${String.Format("{0:0.00}", conta2.saldo)}");
            */

            /*Titular.Cliente cliente1 = new Titular.Cliente();
            cliente1.nome = "Luana";
            cliente1.cpf = "12345678987";
            cliente1.profissao = "Garota de Programa";*/

            /*ContaCorrente conta1 = new ContaCorrente();
            conta1.titular = new Cliente();
            conta1.titular.nome = "Luana Yasmim";
            conta1.titular.cpf = "12345678987";
            conta1.titular.profissao = "Garota de Programa";
            Cliente luana = new Cliente();
            conta1.Titular=luana;
            conta1.conta = "12345-y";
            conta1.numeroAgencia = 20;
            conta1.nomeAgencia = "CentralByte";
            //conta1.saldo = 0.00;
            conta1.ativo = true;

            //Definindo o saldo a partir de um metódo 
            conta1.Saldo=1500;

            Console.WriteLine(cliente1.nome);
            Console.WriteLine(conta1.titular.nome);
            Console.WriteLine($"Saldo: {conta1.Saldo}");*/




        }
    }
}
