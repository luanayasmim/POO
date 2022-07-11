using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo banco");

            Conta p1 = new Conta();
            p1.setNumConta(9807);
            //p1.setTipo("Conta Corrente");
            p1.setTitular("Yasmim");
            //p1.setSaldo(1);
            p1.setStatus(true);
            p1.abrirConta("Conta Corrente");
            p1.depositar(500);
            p1.estadoAtual();

            Conta p2 = new Conta();
            p2.setNumConta(9808);
            //p2.setTipo("Conta Poupança");
            p2.setTitular("Fernanda");
            //p1.setSaldo(1);
            p2.setStatus(true);
            p2.abrirConta("Conta Poupança");
            p2.depositar(300);
            p2.sacar(800);
            p2.estadoAtual();
        }
    }
}
