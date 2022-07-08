using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            this.CPF = cpf;
            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

        /*private string _nome;
        private string _cpf;
        private double _salario;

        //private int _tipo;


        //Encapsulamento
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; private set => _cpf = value; }
        public double Salario { get => _salario; protected set => _salario = value; }



        
         * 0) Funcionário
         * 1) Diretor
         * 2) Designer
         

        //Virtual - Declara que o método pode ser reescrito nas subclasses(Diretor)
        public virtual double getBonificacao()
        {
            return Salario * 0.1;

        }

        //Static - Define que o método seja exclusivamente da classe e não do objeto
        public static int TotalFuncionarios { get; private set; }
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            TotalFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    
        //Construtores
        public Funcionario(int _tipo)
        {
            this._tipo = _tipo;
        }*/
    }
}
