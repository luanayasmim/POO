using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoYoutube
{
    public class Video : AcoesVideo
    {
        public string titulo { get; set; }
        public int avaliacao { get; set; }
        public int views { get; set; }
        public int  curtidas { get; set; }
        public bool reproduzindo { get; set; }


        public Video(string p_titulo)
        {
            this.titulo = p_titulo;
            this.avaliacao = 1;
            this.views = 0;
            this.curtidas = 0;
            this.reproduzindo = false; 
        }

        public void Like()
        {
            
        }

        public void Pause()
        {
            
        }

        public void Play()
        {
            
        }
        /*public override String ToString()
        {
            return $"Video {this.titulo}, Avaliação = {this.avaliacao}, Curtidas:{this.curtidas}, Reproduzindo: {this.reproduzindo}";
        }*/
    }
}
