using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoYoutube
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string sexo { get; set; }
        public float experiencia { get; set; }

        public Pessoa(string nome, int idade, string sexo, float experiencia)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
            this.experiencia = experiencia;
        }

    }
}
