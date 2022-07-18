using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    //A classe visitante é considerada uma classe pobre, pois não tem atributos ou metódos para diferenciação
    //Esta classe apenas herda as caracteriscas de Pessoa
    public class Visitante : Pessoa
    {
        public Visitante(string nome, int idade, string sexo) : base(nome, idade, sexo)
        {
            SetNome(nome);
            SetIdade(idade);
            SetSexo(sexo);
        }
    }
}
