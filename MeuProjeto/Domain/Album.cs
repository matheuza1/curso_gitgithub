using System;
using MeuProjeto.Domain;
  
// teste para o gitdesktop
namespace MeuProjeto.Domain
{
    public class Album 
    {
        public int IdAlbum { get; set; }
        public string NomeAlbum { get; set; }
        public TimeSpan DuracaoAlbum { get; set; }
        public TimeSpan DuracaoMusica { get; }
    }
}

