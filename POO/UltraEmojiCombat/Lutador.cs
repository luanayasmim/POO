using System;
using System.Collections.Generic;
using System.Text;

namespace UltraEmojiCombat
{
    public class Lutador
    {
        //Atributos
        private string nome, nacionalidade, categoria;
        private int idade, vitorias, derrotas, empates;
        private double altura, peso;

        //Métodos Publicos
        public void Apresentar()
        {
            Console.WriteLine("=============================================================================");
            Console.WriteLine($"CHEGOU A HORA! Apresentamos o lutador: {this.GetNome()}");
            Console.WriteLine($"Diretamente de {this.GetNacionalidade()}");
            Console.WriteLine($"Idade: {this.GetIdade()}");
            Console.WriteLine($"Pesando: {this.GetPeso()} KG");
            Console.WriteLine($"Se encaixa na Categoria: {this.GetCategoria()}");
            Console.WriteLine($"Com {this.GetVitorias()} vitórias, {this.GetDerrotas()} derrotas e {this.GetEmpates()} empates");
        }
        public void Status()
        {
            Console.WriteLine($"Lutador: {this.GetNome()}"); 
            Console.WriteLine($"Categoria: {this.GetCategoria()}");
            Console.WriteLine($"Com {this.GetVitorias()} vitórias, {this.GetDerrotas()} derrotas e {this.GetEmpates()} empates");



        }
        public void GanharLuta()
        {
            this.SetVitorias(this.GetVitorias() + 1);
        }
        public void PerderLuta()
        {
            this.SetDerrotas(this.GetDerrotas() + 1);
        }
        public void EmpatarLuta()
        {
            this.SetEmpates(this.GetEmpates() + 1);
        }
        //Métodos Especiais
        public Lutador(string p_nome,
                       string p_nacionalidade, 
                       int p_idade,
                       double p_altura,
                       double p_peso,
                       int p_derrotas,
                       int p_vitorias,
                       int p_empates)
        {
            this.nome = p_nome;
            this.nacionalidade = p_nacionalidade;
            this.idade = p_idade;
            this.altura = p_altura;
            this.SetPeso(p_peso);
            this.derrotas = p_derrotas;
            this.vitorias = p_vitorias;
            this.empates = p_empates;
        }
        
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetNacionalidade()
        {
            return this.nacionalidade;
        }
        public void SetNacionalidade(string nacionalidade)
        {
            this.nacionalidade = nacionalidade;
        }
        public int GetIdade()
        {
            return this.idade;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public double GetAltura()
        {
            return this.altura;
        }
        public void SetAltura(double altura)
        {
            this.altura = altura;
        }
        public double GetPeso()
        {
            return this.peso;
        }
        public void SetPeso(double peso)
        {
            this.peso = peso;
            this.SetCategoria();
        }
        public string GetCategoria()
        {
            return this.categoria;
        }
        private void SetCategoria()
        {
            if (GetPeso() < 52.2)
                this.categoria = "Inválido";
            else if (GetPeso() <= 70.3)
                this.categoria = "Leve";
            else if(GetPeso()<=83.9)
                this.categoria = "Médio";
            else if (GetPeso()<=120.2)
                this.categoria = "Pesado";
            else
                this.categoria = "Inválido";
        }
        public int GetVitorias()
        {
            return this.vitorias;
        }
        public void SetVitorias(int vitorias)
        {
            this.vitorias = vitorias;
        }
        public int GetDerrotas()
        {
            return this.derrotas;
        }
        public void SetDerrotas(int derrotas)
        {
            this.derrotas = derrotas;
        }
        public int GetEmpates()
        {
            return this.empates;
        }
        public void SetEmpates(int empates)
        {
            this.empates = empates;
        }

    }
}
