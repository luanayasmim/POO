using System;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo(a) ao FastFood :)");

            Pedido pedido1 = new Pedido();
            pedido1.numero_Pedido = 1;
            pedido1.cliente.nome = "Luana Yasmim";
            pedido1.cliente.cpf = "12345678987";
            pedido1.cliente.email = "luana@email.com";
            pedido1.cliente.endereco.rua = "Estrada da Mandioca";
            pedido1.cliente.endereco.bairro = "Parque Mandiqueira";
            pedido1.cliente.endereco.cidade = "Cidade Nárnia";
            pedido1.cliente.endereco.numero = 666;
            pedido1.cliente.endereco.cep = "99999-99";
            pedido1.item.quantidade = 10;
            pedido1.total_Pedido = 100;


            Console.ReadKey();
        }
    }
}
