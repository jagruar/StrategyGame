using System;
using System.Collections.Generic;
using System.Text;
using Models.Buildings;

namespace Models
{
    public class GameState
    {
        public List<ITile> Tiles { get; set; }

        public List<Player> Players { get; set; }
    }
}
