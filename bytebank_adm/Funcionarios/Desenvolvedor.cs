using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class Desenvolvedor:Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
