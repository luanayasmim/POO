using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Cachorro : Mamifero
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Auau");
        }
    }
}
