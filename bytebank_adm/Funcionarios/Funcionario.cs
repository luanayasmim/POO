using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public class Funcionario
    {
        
        private string _nome;
        private string _cpf;
        private double _salario;

        private int _tipo;


        //Encapsulamento
        public string Nome { get=>_nome; set=>_nome=value; }
        public string Cpf { get=>_cpf; set=>_cpf=value; }
        public double Salario { get => _salario; set => _salario = value; }


        
        /*
         * 0) Funcionário
         * 1) Diretor
         * 2) Designer
         */
        public double getBonificacao()
        {
            return Salario*0.1;

        }

        //Construtores
        public Funcionario(int _tipo)
        {
            this._tipo = _tipo;
        }
    }
}
