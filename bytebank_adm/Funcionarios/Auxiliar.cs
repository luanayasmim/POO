using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Funcionarios
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Contador contratado!");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.17;
        }

        public override double getBonificacao()
        {
            return Salario *= 0.17;
        }

    }
}
