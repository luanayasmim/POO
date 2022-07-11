using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Caneta
    {
        //Definindo Atributos da Caneta
        public string modelo;
        public string cor;
        private double ponta;
        protected int carga;
        protected bool tampada;

        //Métodos Especiais

        //Método Construtor
        public Caneta(string modelo, string cor, double ponta)
        {
            this.Tampar();
            this.modelo = modelo;
            this.cor = "Azul";
            this.ponta = ponta;
        }
        //Getter
        public String getModelo()
        {
            return this.modelo;
        }
        public double getPonta()
        {
            return this.ponta;
        }

        //Setter
        public void setModelo(string modelo)
        {
            //O this é usado para se referenciar a algum atributo ou metódo da Classe
            this.modelo = modelo;
        }
        public void setPonta(double ponta)
        {
            this.ponta = ponta;
        }

        //Definindo métodos
        public void Status()
        {
            Console.WriteLine("Modelo: "+this.getModelo());
            Console.WriteLine("Uma caneta "+this.cor);
            Console.WriteLine("Ponta: " + this.getPonta());
            Console.WriteLine("Carga: "+this.carga);
            Console.WriteLine("Está tampada? " + this.tampada);
        }
        public void Rabiscar()
        {
            if (this.tampada)
            {
                Console.WriteLine("Erro! Não posso escrever");
            }
            else
            {
                Console.WriteLine("Rabiscando...");
            }

        }
        protected void Tampar()
        {
            this.tampada = true;
        }
        protected void Destampar()
        {
            this.tampada = false;
        }


    }
}
