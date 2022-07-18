using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Tecnico : Aluno
    {
        private string registroProfissional;

        public Tecnico(string nome, int idade, string sexo, int matricula, string curso, string registroProfissional) : base(nome, idade, sexo, matricula, curso)
        {
            SetRegistroProfissional(registroProfissional);
        }

        public string GetRegistroProfissional()
        {
            return this.registroProfissional;
        }
        public void SetRegistroProfissional(string p_registroProfissional)
        {
            this.registroProfissional = p_registroProfissional;
        }

        public void Praticar()
        {
            Console.WriteLine("O aluno está praticando!");
        }
    }
}
