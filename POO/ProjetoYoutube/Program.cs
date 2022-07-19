using System;
using System.Collections.Generic;

namespace ProjetoYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> list_video = new List<Video>();
            list_video[0] = new Video("Aula 1 de POO");
            list_video[1] = new Video("Aula 12 de PHP");
            list_video[2] = new Video("Aula 10 de HTML5");

            Console.WriteLine(list_video[0]);

            

        }
    }
}
