using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Controle : ControleInterface
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
        
        //Métodos
        public void Ligar()
        {
            this.setLigado(true);
        }
        public void Desligar()
        {
            this.setLigado(false);
        }
        public void AbrirMenu()
        {
            Console.WriteLine($"Está ligado? {getLigado()}");
            Console.WriteLine($"Está tocando {getTocando()}");
            Console.Write($"Volume: {getVolume()}");
            for(int i = 0; i <= getVolume(); i+=10)
            {
                Console.Write("|");
            }
            
        }
        public void FecharMenu()
        {
            Console.WriteLine("Fechando o Menu (;");
        }
        public void AumentarVolume()
        {
            if (this.getLigado())
            {
                this.setVolume(this.getVolume() + 5);
            }
        }
        public void AbaixarVolume()
        {
            if (this.getLigado())
            {
                this.setVolume(this.getVolume() - 5);
            }

        }
        public void AtivarMudo()
        {
            if (this.getLigado() && this.getVolume()>0)
            {
                this.setVolume(0);
            }
        }
        public void DesativarMudo()
        {
            if (this.getLigado() && this.getVolume() == 0)
            {
                this.setVolume(50);
            }

        }
        public void Play()
        {
            if(this.getLigado() && !(this.getTocando()))
            {
                this.setTocando(true);
            }
        }
        public void Pause()
        {
            if (this.getLigado() && this.getTocando())
            {
                this.setTocando(false);
            }
        }
    }
}
 