using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Controle 
    {
        //Atributos
        private int volume;
        private bool ligado;
        private bool tocando;

        //Métodos especiais
        public Controle()
        {
            this.volume = 50;
            this.ligado = false;
            this.tocando = false;
        }

        private int getVolume()
        {
            return this.volume;
        }
        private void setVolume(int volume)
        {
            this.volume = volume;
        }

        private bool getLigado()
        {
            return this.ligado;
        }
        private void setLigado(bool ligado)
        {
            this.ligado = ligado;
        }

        private bool getTocando()
        {
            return this.tocando;
        }

        private void setTocando(bool tocando)
        {
            this.tocando = tocando;
        }

        public void abrirMenu()
        {
            Console.WriteLine(getLigado());
            Console.WriteLine(getVolume());
            for(int i = 0; i < getVolume(); i+=10)
            {
                Console.WriteLine("|");
            }
            Console.WriteLine("Tocando....");
        }
        public void fecharMenu()
        {
            Console.WriteLine("Fechando o Menu (;");
        }
    }
}
