using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] ListPessoas = new Pessoa[3];
            Livro[] ListLivros = new Livro[4];

            ListPessoas[0] = new Pessoa("Luana", 18, "F");
            ListPessoas[1] = new Pessoa("Yasmim", 18, "F");
            ListPessoas[2] = new Pessoa("Caio", 19, "M");

            ListLivros[0] = new Livro("Por Lugares Incriveis", "Jennifer Niven", 295, ListPessoas[0]);
            ListLivros[1] = new Livro("Cantiga dos Pássaros e das Serpentes", "Suzanne Collins", 507, ListPessoas[1]);
            ListLivros[2] = new Livro("A Casa de Hades", "Rick Riordan", 608, ListPessoas[2]);
            ListLivros[3] = new Livro("A Marca de Atena", "Rick Riordan", 584, ListPessoas[2]);

            ListLivros[1].Detalhes();
            ListLivros[0].Abrir();
            ListLivros[0].AvancarPagina();
            ListLivros[0].Folhear(100);
            ListLivros[0].Detalhes();
        }
    }
}
