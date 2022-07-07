using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public class Contador:Funcionario
    {
        public Contador(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Contador contratado!");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double getBonificacao()
        {
            return Salario *= 0.17;
        }

    }
}
