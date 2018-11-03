using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface ITile
    {
        int X { get; set; }

        int Y { get; set; }

        int? PlayerId { get; set; }

        IBuilding Building { get; set; }

        List<Wall> Walls { get; set; }

        int ContestedTurnsRemaining { get; set; }

        bool CanLeave { get; set; }
    }
}
