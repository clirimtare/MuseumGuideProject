﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumGuide.BLL
{
    class Exhibit
    {
        public int ExhibitID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ItemID { get; set; }
        public int Floor { get; set; }
        public int Sector { get; set; }

    }
}
