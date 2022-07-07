using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public class Diretor:Funcionario
    {
        /*private string _nome;
        private string _cpf;
        private double _salario;

        //Encapsulamento
        public string Nome { get => _nome; set => _nome = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public double Salario { get => _salario; set => _salario = value; }*/

        //Override - Define que é uma reescrita do metódo declarado na classe base (funcionário)
        public override double getBonificacao()
        {
            return Salario * 0.5;
        }

        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Diretor criado!");
        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.5;
        }
    }
}
