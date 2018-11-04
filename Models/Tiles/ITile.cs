using System;
using System.Collections.Generic;
using System.Text;
using Models.Buildings;
using Models.Armies;

namespace Models
{
    public interface ITile
    {
        int X { get; set; }

        int Y { get; set; }

        int? PlayerId { get; set; }

        IBuilding Building { get; set; }

        IArmy Army { get; set; }

        List<Wall> Walls { get; set; }

        /// <summary>
        /// A player cannot alter buildings or walls in a contested tile.
        /// Only special units can heal in a contested tile
        /// </summary>
        int ContestedTurnsRemaining { get; set; }

        /// <summary>
        /// A unit cannot leave or fortify in a resisted tile 
        /// </summary>
        bool IsResisted { get; set; }
    }
}
