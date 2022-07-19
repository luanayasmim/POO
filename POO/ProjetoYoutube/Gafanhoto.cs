using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoYoutube
{
    public class Gafanhoto : Pessoa
    {
        public Gafanhoto(string login, int totalAssistido)
        {
            this.login = login;
            this.totalAssistido = totalAssistido;
        }

        public string login { get; set; }
        public int totalAssistido { get; set; }

        //public Gafanhoto(string p_nome, string login)
        //{
        //    //super(nome, idade, sexo);
        //    this.login = login;
        //    this.nome = p_nome;
        //    this.totalAssistido = 0;
        //}

    }
}
