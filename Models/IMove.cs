using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IMove
    {
        bool IsValid(GameState gameState);

        bool Process(GameState gameState);
    }
}
