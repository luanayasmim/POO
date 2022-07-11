using System;
using mercadinho;

namespace Mercadinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) ao Mercadinho :)");

            Produto achocolatado = new Produto();

            achocolatado.nomeProduto = "Toddy";
            achocolatado.codigo_barrasProduto = 123456789;
            achocolatado.valor_unitarioProduto = 8.29;
            achocolatado.valor_totalProduto = 207.25;
            achocolatado.qtd_estoqueProduto = 25;

            Console.WriteLine($@"Produto: {achocolatado.nomeProduto}
Código de Barras: {achocolatado.codigo_barrasProduto}
Valor Unitário: R$ {achocolatado.valor_unitarioProduto}
Valor Total do Produto: R$ {achocolatado.valor_totalProduto}
Quantidade em Estoque: {achocolatado.qtd_estoqueProduto}");

            Console.ReadKey();
        }
    }
}
