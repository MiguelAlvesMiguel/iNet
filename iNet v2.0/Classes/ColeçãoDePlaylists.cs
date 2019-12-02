using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace iNet_v2._0
{
   public class ColeçãoDePlaylists : CollectionBase
   {
      //Props (INDEXER)
      public Playlist this[int idx]
      {
         get
         { return (Playlist) List[idx]; }
         set
         { List[idx] = value; }
      }
      //
      //Builders
      public ColeçãoDePlaylists()
      {
      }
      //
   }
}
