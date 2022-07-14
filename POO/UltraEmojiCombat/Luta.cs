using System;
using System.Collections.Generic;
using System.Text;

namespace UltraEmojiCombat
{
    public class Luta
    {
        //Atributos
        private Lutador lutador1, lutador2;
        private int rounds;
        private bool aprovada;

        //Métodos Especiais
        public Lutador GetLutador1()
        {
            return this.lutador1;
        }
        public void SetLutador1(Lutador lutador1)
        {
            this.lutador1 = lutador1;
        }
        public Lutador GetLutador2()
        {
            return this.lutador2;
        }
        public void SetLutador2(Lutador lutador2)
        {
            this.lutador2 = lutador2;
        }
        public int GetRounds()
        {
            return this.rounds;
        }
        public void SetRounds(int rounds)
        {
            this.rounds = rounds;
        }
        public bool GetAprovada()
        {
            return this.aprovada;
        }
        public void SetAprovada(bool aprovada)
        {
            this.aprovada = aprovada;
        }

        //Métodos Públicos
        public void MarcarLuta(Lutador lutador1,
                               Lutador lutador2)
        {
            if (lutador1.GetCategoria() == lutador2.GetCategoria() && lutador1!=lutador2 )
            {
                SetAprovada(true);
                SetLutador1(lutador1);
                SetLutador2(lutador2);
            }
            else
            {
                SetAprovada(false);
                SetLutador1(null);
                SetLutador2(null);
            }
        }

        public void Lutar()
        {
            if (this.GetAprovada())
            {
                Console.WriteLine("### PRIMEIRO LUTADOR ###");
                GetLutador1().Apresentar();
                Console.WriteLine();
                Console.WriteLine("### SEGUNDO LUTADOR ###");
                this.GetLutador2().Apresentar();

                Random random = new Random();
                int vencedor = random.Next(3);
                switch (vencedor)
                {
                    case 0: //Empate
                        Console.WriteLine("Empatou!");
                        this.lutador1.EmpatarLuta();
                        this.lutador2.EmpatarLuta();
                        break;

                    case 1: //Lutador1 ganha
                        Console.WriteLine($"O {this.lutador1.GetNome()} ganhou a luta!");
                        this.lutador1.GanharLuta();
                        this.lutador1.PerderLuta();
                        break; 

                    case 2: //Lutador2 ganha
                        Console.WriteLine($"O {this.lutador2.GetNome()} ganhou a luta!");
                        this.lutador2.GanharLuta();
                        this.lutador1.PerderLuta();
                        break;

                }
            }
        }
    }
}
