using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public class Livro:Publicacao
    {
        private string titulo;
        private string autor;
        private int totalPaginas;
        private int paginaAtual;
        private bool aberto;
        private Pessoa leitor;

        public Livro(string titulo,
                     string autor,
                     int totalPaginas,
                     //int paginaAtual,
                     //bool aberto,
                     Pessoa leitor)
        {
            SetTitulo(titulo);
            SetAutor(autor);
            SetTotalPaginas(totalPaginas);
            //SetPaginaAtual(paginaAtual);
            SetPaginaAtual(0);
            this.aberto = false;
            //SetAberto(aberto);
            SetLeitor(leitor);

        }

        public string GetTitulo()
        {
            return this.titulo;
        }
        public void SetTitulo(string p_titulo)
        {
            this.titulo = p_titulo;
        }
        public string GetAutor()
        {
            return this.autor;
        }
        public void SetAutor(string p_autor)
        {
            this.autor = p_autor;
        }
        public int GetTotalPaginas()
        {
            return this.totalPaginas;
        }
        public void SetTotalPaginas(int p_totalPaginas)
        {
            this.totalPaginas = p_totalPaginas;
        }
        public int GetPaginaAtual()
        {
            return this.paginaAtual;
        }
        public void SetPaginaAtual(int p_paginaAtual)
        {
            this.paginaAtual = p_paginaAtual;
        }
        public bool GetAberto()
        {
            return this.aberto;
        }
        public void SetAberto(bool p_aberto)
        {
            this.aberto = p_aberto;
        }
        public Pessoa GetLeitor()
        {
            return this.leitor;
        }
        public void SetLeitor(Pessoa p_leitor)
        {
            this.leitor = p_leitor;
        }

        //Métodos públicos
        public void Detalhes()
        {
            Console.WriteLine($"Título: {GetTitulo()}");
            Console.WriteLine($"Autor: {GetAutor()}");
            Console.WriteLine($"Total de Páginas: {GetTotalPaginas()}");
            Console.WriteLine($"Página Atual: {GetPaginaAtual()}");
            Console.WriteLine($"Aberto: {GetAberto()}");
            Console.WriteLine($"Leitor: {GetLeitor().GetNome()}");
            Console.WriteLine($"Idade do Leitor: {GetLeitor().GetIdade()}");
            Console.WriteLine($"Sexo do Leitor: {GetLeitor().GetSexo()}");


        }

        public void Abrir()
        {
            if (!GetAberto())
            {
                SetAberto(true);
                Console.WriteLine("O livro foi aberto!");
            }
            else
            {
                Console.WriteLine("O livro já está aberto");
            }
        }

        public void Fechar()
        {
            if (GetAberto())
            {
                SetAberto(false);
                Console.WriteLine("O livro foi fechado");
            }
            else
            {
                Console.WriteLine("O livro já está fechado");
            }
        }

        public void Folhear(int pagina)
        {
            SetPaginaAtual(pagina);
        }

        public void AvancarPagina()
        {
            if (GetPaginaAtual() < GetTotalPaginas())
            {
                SetPaginaAtual(GetPaginaAtual() + 1);
            }
            else
            {
                Console.WriteLine("Fim do livro");
            }
        }

        public void VoltarPagina()
        {
            if (GetPaginaAtual() < 1 )
            {
                Console.WriteLine("Você está na primeira página!");
            }else
            {
                SetPaginaAtual(GetPaginaAtual() - 1);
            }
        }
    }
}
