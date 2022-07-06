using System;
using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        //Atributos
        /*private Cliente titular;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        private double saldo;
        public bool ativo;*/

        public Cliente Titular { get; set; }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                    return;
                else
                    _conta = value;
            }

        }
        private int _numero_agencia;
        public int NumeroAgencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (_numero_agencia <= 0) { }
                   
                else
                    _numero_agencia = value;
                
            }
        }
        public string NomeAgencia { get; set; }

        private double saldo;

        //Métodos
        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor || valor<0)
                return false;
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        /*public void SetSaldo(double saldo)
        {
            if (saldo < 0)
                return;
            else
                this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }*/

        //Utilizando o GET e o SET para manipular o saldo
        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                    return;
                else
                    this.saldo = value;
            }
        }

        public ContaCorrente(int _numero_agencia, string conta)
        {
            NumeroAgencia = _numero_agencia;
            Conta = _conta;

            TotalContasCriadas += 1;
        }

        public static int TotalContasCriadas { get; set; }
    }
} 