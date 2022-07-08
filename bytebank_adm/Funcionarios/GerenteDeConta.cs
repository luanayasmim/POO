using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank_adm.Funcionarios
{
    public class GerenteDeConta:FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
