using System;
using System.Collections.Generic;

namespace UltraEmojiCombat
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Lutador listaLutadores[] = new Lutador[6];
            //listaLutadores[0] = new Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11, 2, 1);

            List<Lutador> listaLutadores = new List<Lutador>
            {
                new Lutador("Pretty Boy", "França", 31, 1.75, 68.9, 11, 2, 1),
                new Lutador("PutScript", "Brasil", 29, 1.68, 57.8, 14, 2, 3),
                new Lutador("SnapShadow", "EUA", 35, 1.65, 80.9, 12, 2, 1),
                new Lutador("Dead Code", "Austrália", 28, 1.93, 81.6, 13, 0, 2),
                new Lutador("UfoCobol", "Brasil", 37, 1.70, 119.3, 5, 4, 3),
                new Lutador("Nerdaart", "EUA", 30, 1.81, 105.7, 12, 2, 4),
            };

            
            listaLutadores[1].Apresentar();


            Luta UEC01 = new Luta();
            UEC01.MarcarLuta(listaLutadores[0], listaLutadores[1]);
            UEC01.Lutar();
        }
    }
}
