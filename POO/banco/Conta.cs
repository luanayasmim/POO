using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    public class Conta
    {
        public float numConta;
        protected string tipo;
        private string titular;
        private double saldo;
        private bool status;

        //Metódos Especiais
        public Conta()
        {
            this.setSaldo(0);
            this.status = false;
        }
        public void setNumConta(float num){this.numConta = num;}
        public float getNumConta(){return numConta;}
        public void setTipo(string tipo){this.tipo = tipo;}
        public string getTipo(){return this.tipo;}
        public void setTitular(string titular){this.titular = titular;}
        public string getTitular(){return this.titular;}
        public void setSaldo(double saldo){this.saldo = saldo;}
        public double getSaldo(){return this.saldo;}
        public void setStatus(bool status){this.status = status;}
        public bool getStatus(){return this.status;}

        //Metódos
        public void abrirConta(string tipoConta)
        {
            setTipo(tipoConta);
            setStatus(true);

            if(tipoConta=="Conta Corrente")
            {
                setSaldo(50);
            }else if(tipoConta=="Conta Poupança")
            {
                setSaldo(150);
            }

        }
        public void fecharConta()
        {
            if (getSaldo() > 0)
            {
                Console.WriteLine("Conta com dinheiros! Por favor realize o Saque para que a conta possa ser encerrada!");
            }else if (getSaldo() < 0)
            {
                Console.WriteLine("Conta com saldo negativo. Pague suas dívidas sem fugir!");
            }
            else
            {
                setStatus(false);
            }

        }
        public void depositar(double valor)
        {
            if (getStatus()==true)
            {
                setSaldo(getSaldo() + valor);
                //this.saldo += valor;
            }

        }
        public void sacar(double valor)
        {
            if (getStatus() && getSaldo()>valor)
            {
                setSaldo(getSaldo() - valor);
            }else if (getSaldo() < valor)
            {
                Console.WriteLine("Saldo insuficiente!");
            }else if (!getStatus())
            {
                Console.WriteLine("Conta Desativada!");
            }

        }
        public void pagarMensal()
        {
            double valorMensal=0;

            if(getTipo()== "Conta Corrente")
            {
                valorMensal = 12;
            }else if(getTipo()=="Conta Poupança")
            {
                valorMensal = 20;
            }

            if (getStatus()==true)
            {
                if (this.saldo > valorMensal)
                {
                    setSaldo(getSaldo() - valorMensal);
                }
                else
                {
                    Console.WriteLine("Saldo Insuficiente!");
                }
            }
            else
            {
                Console.WriteLine("Conta Desativada!");
            }
        }

        public void estadoAtual()
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine($"Número: {this.getNumConta()}");
            Console.WriteLine($"Tipo: {this.getTipo()}");
            Console.WriteLine($"Nome do titular: {this.getTitular()}");
            Console.WriteLine($"Saldo: {this.getSaldo()}");
            Console.WriteLine($"Status: {this.getStatus()}");
        }

        
    }
}
