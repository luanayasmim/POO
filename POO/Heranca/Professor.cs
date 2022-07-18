using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    //Classe Filha/Subclasse de Pessoa
    //Todas as caractéristicas da classe pessoa está sendo atribuido a classe Professor
    public class Professor : Pessoa
    {
        private string especialidade;
        private float salario;

        public Professor(string nome, int idade, string sexo, string especialidade, float salario) : base(nome, idade, sexo)
        {
            SetNome(nome);
            SetIdade(idade);
            SetSexo(sexo);
            SetEspecialidade(especialidade);
            SetSalario(salario);
        }

        public string GetEspecialidade()
        {
            return this.especialidade;
        }
        public void SetEspecialidade(string p_especialidade)
        {
            this.especialidade = p_especialidade;
        }
        public float GetSalario()
        {
            return this.salario;
        }
        public void SetSalario(float p_salario)
        {
            this.salario = p_salario;
        }

        public void ReceberAumento(float valor)
        {
            SetSalario(GetSalario() + valor);
            Console.WriteLine($"O novo salário é: {GetSalario()}");
        }
    }
}
