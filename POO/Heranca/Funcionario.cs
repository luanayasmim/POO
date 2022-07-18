using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    //Classe Filha/Subclasse de Pessoa
    //Todas as caractéristicas da classe pessoa está sendo atribuido a classe Funcionario
    public class Funcionario : Pessoa
    {
        private string setor;
        private bool trabalhando;

        public Funcionario(string nome, int idade, string sexo, string setor, bool trabalhando) : base(nome, idade, sexo)
        {
            SetNome(nome);
            SetIdade(idade);
            SetSexo(sexo);
            SetSetor(setor);
            SetTrabalhando(trabalhando);
        }

        public string GetSetor()
        {
            return this.setor;
        }
        public void SetSetor(string p_setor)
        {
            this.setor = p_setor;
        }
        public bool GetTrabalhando()
        {
            return this.trabalhando;
        }
        public void SetTrabalhando(bool p_trabalhando)
        {
            this.trabalhando = p_trabalhando;
        }

        public void MudarTrabalho()
        {
            this.trabalhando = !this.trabalhando;
        }
    } 
}
