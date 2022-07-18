using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    //Classe Filha/Subclasse de Pessoa
    //Todas as caractéristicas da classe pessoa está sendo atribuido a classe Aluno
    public class Aluno : Pessoa
    {
        private int matricula;
        private string curso;
        public Aluno(string nome, int idade, string sexo, int matricula, string curso) : base(nome, idade, sexo)
        {
            SetNome(nome);
            SetIdade(idade);
            SetSexo(sexo);
            SetMatricula(matricula);
            SetCurso(curso);
        }

        public int GetMatricula()
        {
            return this.matricula;
        }
        public void SetMatricula(int p_matricula)
        {
            this.matricula = p_matricula;
        }
        public string GetCurso()
        {
            return this.curso;
        }
        public void SetCurso(string p_curso)
        {
            this.curso = p_curso;
        }

        public void cancelarMatricula()
        {
            Console.WriteLine("A matricula será cancelada");
        }

        //A declaração do método com o atributo Virtual faz com que o método seja sobreescrito pelas filhas
        public virtual void PagarMensalidade()
        {
            Console.WriteLine($"Pagando mensalidade do aluno {this.GetNome()}");
        }
    }
}
