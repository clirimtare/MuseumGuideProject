using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumGuide.BO
{
    public class BaseObject
    {
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int LastUpdateNo { get; set; } = 0;
    }
}
