using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Caneta 1
            Console.WriteLine("Caneta 1");
            Caneta c1 = new Caneta();
            c1.modelo = "FaberCastell";
            c1.cor = "Preta";
            c1.ponta = 0.5;
            c1.tampada = false;
            c1.Tampar();
            //c1.Destampar();
            c1.Status();
            c1.Rabiscar();

            //Caneta 2
            Console.WriteLine("Caneta 2");
            Caneta c2 = new Caneta();
            c2.modelo = "Bic";
            c2.cor = "Azul";
            c2.ponta = 0.5;
            c2.tampada = false;
            //c2.Tampar();
            c2.Destampar();
            c2.Status();
            c2.Rabiscar();

            //Celular 1
            Console.WriteLine("Celular 1");
            Celular celular1 = new Celular();
            celular1.modelo = "Galaxy A52";
            celular1.marca = "Samsung";
            celular1.sistemaOperacional = "Android";
            celular1.processador = "Octa-Core 2.3GHz";
            celular1.memoriaRam = 6;
            celular1.armazenamento = 128;
            celular1.qtdaCamera = 5;
            celular1.bateria = 100;
            celular1.leituraDigital = true;
            celular1.entradaFone = true;

            celular1.Ligar();
            celular1.Desligar();
            celular1.Carregar();
            celular1.Utilizar();

            //Celular 2
            Console.WriteLine("Celular 2");
            Celular celular2 = new Celular();
            celular2.modelo = "Moto G6 Play";
            celular2.marca = "Motorola";
            celular2.sistemaOperacional = "Android";
            celular2.processador = "Octa-Core 1.4 GHz - Qualcomm Snapdragon 430 (MSM8937)";
            celular2.memoriaRam = 3;
            celular2.armazenamento = 32;
            celular2.qtdaCamera = 2;
            celular2.bateria = 0;
            celular2.leituraDigital = true;
            celular2.entradaFone = true;
                   
            celular2.Ligar();
            celular2.Desligar();
            celular2.Carregar();
            celular2.Utilizar();

            //Comer1
            Comer comer1 = new Comer();
            comer1.comida = "Lasanha";
            comer1.temComida = true;
            comer1.taComFome = true;
            comer1.PodeComer();

            //Comer2
            Comer comer2 = new Comer();
            comer2.comida = "";
            comer2.temComida = false;
            comer2.taComFome = false;
            comer2.PodeComer();

        }          
    }
}
