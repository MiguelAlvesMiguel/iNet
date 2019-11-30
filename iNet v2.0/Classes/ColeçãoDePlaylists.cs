using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Classes
{
   public class ColeçãoDePlaylists : CollectionBase
   {
     private Playlist[] Playlists;

      public Playlist this[int idx]
      {
         get
         { return Playlists[idx]; }
         set
         { Playlists[idx] = value; }
      }

      public ColeçãoDePlaylists()
      {
         Musica[] Playlists = new Musica[100];
      }
      public ColeçãoDePlaylists(int n_musicas)
      {
         Musica[] Playlists = new Musica[n_musicas];
      }
   }
}
