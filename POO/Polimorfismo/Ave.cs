using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Ave : Animal
    {
        public string CorPena { get; set; }
        public override void Alimentar()
        {
            Console.WriteLine("Ave vai de frutinha po");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Cantando");
        }

        public override void Locomover()
        {
            Console.WriteLine("Voandinho");
        }
        public void fazerNinho()
        {
            Console.WriteLine("Construindo ninho");
        }
    }
}
