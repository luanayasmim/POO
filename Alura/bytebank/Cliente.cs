using System;
using System.Collections.Generic;
using System.Text;
using bytebank.Titular;

namespace bytebank.Titular
{
    public class Cliente
    {

        public string Cpf { get; set; }
        public Cliente titular;
        public string Nome { get; set; }
        public string Profissao { get; set; }
    }
}
