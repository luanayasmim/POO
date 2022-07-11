using System;
using consultorio;

namespace Consultorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo(a) ao Consultório!");

            Paciente paciente = new Paciente();
            
            Console.WriteLine($@"Nome: {paciente.nomePaciente}
Idade {paciente.idadePaciente}
Altura: {paciente.alturaPaciente}
Peso: {paciente.pesoPaciente}");

            Console.ReadKey();
        }
    }
}
