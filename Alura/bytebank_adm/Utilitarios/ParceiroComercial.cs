using System;
using System.Collections.Generic;
using System.Text;

namespace bytebank_adm.Utilitarios
{
    public class ParceiroComercial
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
