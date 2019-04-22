using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumGuide.BLL
{
    class BaseObject
    {
 
      public int? UpdateBy { get; set; }
      public DateTime? UpdateDate { get; set; }
      public int LastUpdateNo { get; set; } = 0;
 

    }
}
