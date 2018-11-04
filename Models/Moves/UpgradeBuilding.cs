using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Moves
{
    public class UpgradeBuilding : IMove
    {
        public int[] Arguments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool HasValidArgument()
        {
            throw new NotImplementedException();
        }

        public bool IsValid(GameState gameState)
        {
            throw new NotImplementedException();
        }

        public bool Process(GameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}
