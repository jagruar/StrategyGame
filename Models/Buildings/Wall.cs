using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Buildings
{
    public class Wall
    {
        public SideType Side { get; set; }

        public WallType Level { get; set; }

        public int Defense { get; set; }
    }
}
