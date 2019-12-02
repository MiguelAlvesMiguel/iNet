using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace iNet_v2._0
{
   public class ColeçãoDeMusicas : CollectionBase 
   {

      //Indexer
      public Musica this[int idx]
      {  
         get
         {
            return  (Musica) List[idx] ;
         }
         set
         {
            List[idx] = value;
         }
      }
      //
      //Builders
      public ColeçãoDeMusicas()
      {

      }

      //
   }
}
