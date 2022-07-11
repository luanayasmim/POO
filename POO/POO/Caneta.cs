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
        public double ponta;
        public int carga;
        public bool tampada;

        //Definindo metódos
        public void Status()
        {
            Console.WriteLine("Modelo: "+this.modelo);
            Console.WriteLine("Uma caneta "+this.cor);
            Console.WriteLine("Ponta: "+this.ponta);
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
        public void Tampar()
        {
            this.tampada = true;
        }
        public void Destampar()
        {
            this.tampada = false;
        }


    }
}
