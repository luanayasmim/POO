using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
        /*private string _nome;
        private string _cpf;
        private double _salario;

        //Encapsulamento
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public double Salario { get => _salario; set => _salario = value; }*/

        //Override - Define que é uma reescrita do metódo declarado na classe base (funcionário)

    }
}
