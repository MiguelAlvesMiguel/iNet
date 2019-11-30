using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Playlist
    {
      private int _codigo {get; set;}
      private string _nome {get; set;}
      private DateTime _data_criação {get; set;}
      private ColeçãoDeMusicas _musicas {get; set;}

  

      public Playlist()
      { }
      public Playlist(int cod,string nome,DateTime data_criação,ColeçãoDeMusicas musicas)
      {
         _codigo = cod;
         _nome = nome;
         _data_criação = data_criação;
         _musicas = musicas;
      }
   }
}
