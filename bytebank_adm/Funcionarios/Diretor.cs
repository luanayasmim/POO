using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public class Diretor
    {
        private string _nome;
        private string _cpf;
        private double _salario;

        //Encapsulamento
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public double Salario { get => _salario; set => _salario = value; }

        public double getBonificacao()
        {
            return Salario;
        }
    }
}
