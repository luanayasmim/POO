using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Mamifero : Animal
    {
        public string CorDoPelo { get; set; }
        public override void Alimentar()
        {
            Console.WriteLine("Correndo...");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Som de Mamifero");
        }

        public override void Locomover()
        {
            Console.WriteLine("Mamando");
        }
    }
}
