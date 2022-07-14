using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public interface Publicacao
    {
        public void Abrir();
        public void Fechar();
        public void Folhear(int pagina);
        public void AvancarPagina();
        public void VoltarPagina();
    }
}
