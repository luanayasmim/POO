using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public interface ControleInterface
    {
        //A interface é a maneira que se interage com o objeto

        //Métodos abstratos
        public abstract void Ligar();
        public abstract void Desligar();
        public abstract void AbrirMenu();
        public abstract void FecharMenu();
        public abstract void AumentarVolume();
        public abstract void AbaixarVolume();
        public abstract void AtivarMudo();
        public abstract void DesativarMudo();
        public abstract void Play();
        public abstract void Pause();
    }
}
