using System;

namespace MeuProjeto.Domain
{
    public class Musica
    {
        public int IdMusica { get; set; }
        public string NomeMusica { get; set; }
        public string GeneroMusical { get; }
        public TimeSpan DuracaoMusica { get; set; }        
    }
}

