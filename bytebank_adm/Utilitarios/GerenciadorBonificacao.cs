using System;
using System.Collections.Generic;
using System.Text;
using bytebank_adm.Funcionarios;

namespace bytebank_adm.Utilitarios
{
    class GerenciadorBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
        /*private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }
        public void Registrar(Diretor funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }
        public double getBonificacao()
        {
            return this.totalBonificacao;
        }*/
    }
}
