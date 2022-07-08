using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace bytebank_adm.SistemaInterno
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
