using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class Comer
    {
        //Definindo atribuitos
        public string comida;
        public bool temComida;
        public bool taComFome;


        //Definindo métodos
        public void PodeComer()
        {
            if (temComida && taComFome)
            {
                Console.WriteLine("Pode ir almoçar!");
            }
            else
            {
                Console.WriteLine("Agora não dá pra ir comer :(");
            }
        }

    }
}
