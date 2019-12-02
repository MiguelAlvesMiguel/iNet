using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iNet_v2._0
{
   public class Musica
   {
      //Campos
      private string _artista;
      private string _título;
      private Enum_Gen _genero;
      private string _duração;
      //

      //Props
      public string Artista
      { get { return _artista; } set { _artista = value; } }

      public string Título
      { get { return _título; } set { _título = value; } }

      public Enum_Gen Genero
      { get { return _genero; } set { _genero = value; } }

      public string Duração
      { get { return _duração; } set { _duração = value; } }
      //

      //BUILDERS
      public Musica()
      { }

      public Musica(string artista,string título,Enum_Gen genero, string duração)
      {
         _artista = artista;
         _título = título;
         _genero = genero;
         _duração = duração;
      }
      //
   }
}
