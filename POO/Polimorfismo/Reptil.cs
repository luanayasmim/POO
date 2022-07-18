using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Reptil : Animal
    {
        public string CorEscama { get; set; }
        public override void Alimentar()
        {
            Console.WriteLine("Comendo coisas de reptil.");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Emitindo som de jacaré");
        }

        public override void Locomover()
        {
            Console.WriteLine("Rastejando");
        }
    }
}
