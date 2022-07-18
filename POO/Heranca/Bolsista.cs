using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Bolsista : Aluno
    {
        private float bolsa;
        public Bolsista(string nome, int idade, string sexo, int matricula, string curso) : base(nome, idade, sexo, matricula, curso)
        {
        }

        public float GetBolsa()
        {
            return this.bolsa;
        }
        public void SetBolsa(float p_bolsa)
        {
            this.bolsa = p_bolsa;
        }

        public void RenovarBolsa()
        {
            Console.WriteLine("Bolsa Renovada :)");
        }

        //Quando utilizamos a palavra Override significa que o método foi sobreescrito da superclasse, ou seja
        //Existe o mesmo método da classe mãe, porém o comportamento é diferente na classe filha
        public override void PagarMensalidade()
        {
            Console.WriteLine($"{this.GetNome()} é Bolsista! Pagamento facilitado!");
        }
    }
}
