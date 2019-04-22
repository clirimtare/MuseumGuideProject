﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumGuide.BLL
{
    class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public bool Priority { get; set; }
        public int Floor { get; set; }
        public int Sector { get; set; }

    }
}
