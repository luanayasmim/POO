using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Canguru : Mamifero
    {
        public override void Locomover()
        {
            Console.WriteLine("Saltando");
        }

        public void UsarBolsa()
        {
            Console.WriteLine("Usando bolsa");
        }
    }
}
