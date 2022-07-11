using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Celular
    {
        //Inserindo atributos
        public string modelo;
        public string marca;
        public string sistemaOperacional;
        public string processador;
        public int memoriaRam;
        public int armazenamento;
        public int qtdaCamera;
        public float bateria;
        public bool leituraDigital;
        public bool entradaFone;


        //Inserindo Métodos
        public bool Ligar()
        {
            if(this.bateria > 0)
            {
                Console.WriteLine("Ligando celular!");
                return true;
            }
            else
            {
                Console.WriteLine("Sem bateria para ser ligado!");
                return false;
            }

        }
        public bool Desligar()
        {
            if (this.bateria == 0)
            {
                Console.WriteLine("Desligando o celular por falta de bateria!");
                return true;
            }
            else
            {
                Console.WriteLine("Desligando o celular");
                return false;
            }

        }
        public void Carregar()
        {
            if(this.bateria == 0)
            {
                Console.WriteLine("Convém carregar o celular!");
                Desligar();
            }else if (this.bateria == 100)
            {
                Console.WriteLine("Celular totalmente carregado Zé!");
            }else if (this.bateria>1 && this.bateria<=15)
            {
                Console.WriteLine("Ativado a economia de bateria");
            }

        }
        public void Utilizar()
        {
            if (Ligar())
            {
                Console.WriteLine("Celular está ligado, pode continuar no seu vício!");
            }
            else
            {
                Console.WriteLine("Celular desligado! Aproveita e vai viver :)");
            }

        }

    }
}
