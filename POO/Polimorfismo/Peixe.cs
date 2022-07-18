using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Peixe : Animal
    {
        public string CorEscama { get; set; }
        public override void Alimentar()
        {
            Console.WriteLine("Comando alga!");
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Peixe faz som de peixe");
        }

        public override void Locomover()
        {
            Console.WriteLine("Nadandinho");
        }
        public void SoltarBolha()
        {
            Console.WriteLine("Soltando bolhas");
        }
    }
}
