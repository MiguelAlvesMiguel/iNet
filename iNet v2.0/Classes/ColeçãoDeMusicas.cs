using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Classes
{
   public class ColeçãoDeMusicas : CollectionBase 
   {
      private Musica[] musicas;

      public Musica this[int idx]
      {
         get
         {return musicas[idx];}
         set
         { musicas[idx] = value;}
      }
      public ColeçãoDeMusicas()
      {
         Musica[] musicas = new Musica[100];
      }
      public ColeçãoDeMusicas(int n_musicas)
      {
         Musica[] musicas = new Musica[n_musicas];
      }

   }
}
