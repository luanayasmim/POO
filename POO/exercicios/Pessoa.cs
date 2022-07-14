using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string sexo;

        //Métodos Especiais
        public Pessoa(string nome,
                      int idade,
                      string sexo)
        {
            SetNome(nome);
            SetIdade(idade);
            SetSexo(sexo);

        }
        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string p_nome)
        {
            this.nome = p_nome;
        }
        public int GetIdade()
        {
            return this.idade;
        }
        public void SetIdade(int p_idade)
        {
            this.idade = p_idade;
        }
        public string GetSexo()
        {
            return this.sexo;
        }
        public void SetSexo(string p_sexo)
        {
            this.sexo = p_sexo;
        }

        //Métodos públicos
        public void FazerAniversario()
        {
            SetIdade(this.GetIdade()+1);
        }

    }
}
