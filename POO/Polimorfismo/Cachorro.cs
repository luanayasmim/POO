using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public class Cachorro : Lobo
    {
        //Sobreposição
        public override void EmitirSom()
        {
            Console.WriteLine("Auau");
        }

        //Sobrecarga
        public void Reagir(string frase)
        {
            if(frase=="Toma comida" || frase == "Olá")
            {
                Console.WriteLine("Abanar e latir");
            }
            else
            {
                Console.WriteLine("Rosnar");
            }
        }
        public void Reagir(int hora, int minuto)
        {
            if (hora < 12)
            {
                Console.WriteLine("Abanar o rabo");
            }else if (hora >= 18)
            {
                Console.WriteLine("Ignorar");
            }
            else
            {
                Console.WriteLine("Abanar e latir");
            }

        }
        public void Reagir(bool dono)
        {
            if (dono)
            {
                Console.WriteLine("Abanar");
            }
            else
            {
                Console.WriteLine("Rosnar");
            }
        }
        public void Reagir(int idade, float peso)
        {
            if (idade < 5)
            {
                if(peso<10)
                    Console.WriteLine("Abanar");
                else
                    Console.WriteLine("Latir");
            }
            else
            {
                if(peso<10)
                    Console.WriteLine("Rosnar");
                else
                    Console.WriteLine("Ignorar");

            }
        }
    }
}
