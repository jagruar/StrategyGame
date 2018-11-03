using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Wall
    {
        public Sides Side { get; set; }

        public WallTypes Level { get; set; }

        public int Defense { get; set; }
    }
}
