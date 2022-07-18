using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public abstract class Animal
    {
        //Métodos Especiais
        protected int Idade { get; set; }
        protected int Membros { get; set; }
        public float Peso { get; set; }

        //Métodos
        public abstract void Locomover();
        public abstract void Alimentar();
        public abstract void EmitirSom();
        
    }
}
