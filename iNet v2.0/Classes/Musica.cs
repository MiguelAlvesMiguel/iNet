using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Musica
   {
      private string _artista {get; set;}
      private string _título {get; set;}
      private Enum_Gen _genero {get; set;}
      private int _duração {get; set;}

      public Musica()
      { }

      public Musica(string artista,string título,Enum_Gen genero,int duração)
      {
         _artista = artista;
         _título = título;
         _genero = genero;
         _duração = duração;
      }

   }
}
