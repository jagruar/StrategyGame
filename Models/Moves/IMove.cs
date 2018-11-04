using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Moves
{
    public interface IMove
    {
        int[] Arguments { get; set; }

        bool HasValidArgument(); 

        bool IsValid(GameState gameState);

        bool Process(GameState gameState);
    }
}
