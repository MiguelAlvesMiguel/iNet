using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iNet_v2._0
{
    public class Playlist
    {
      //Campos
      private int _codigo;
      private string _nome;
      private DateTime _data_criação;
      private ColeçãoDeMusicas _musicas;
      //
      //Props
      public int Codigo
      { get { return _codigo; } set { _codigo = value; } }

      public string Nome
      { get { return _nome; } set { _nome = value; } }

      public DateTime DataCriação
      { get { return _data_criação; } set { _data_criação = value; } }

      public ColeçãoDeMusicas Musicas
      { get { return _musicas; } set { _musicas = value; } }
      //
      //Builders
      public Playlist()
      { }
      public Playlist(int cod,string nome,DateTime data_criação,ColeçãoDeMusicas musicas)
      {
         _codigo = cod;
         _nome = nome;
         _data_criação = data_criação;
         _musicas = musicas;
      }
      //
   }
}
