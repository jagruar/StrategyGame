using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Services
{
    class GameService
    {
        public GameState GameState { get; set; }

        public void ProcessTurn(Turn turn)
        {
            UpdateBuildings(turn);
            UpdateResources(turn);
            ProcessConflicts(turn);
        }

        private void UpdateBuildings(Turn turn)
        {

        }

        private void UpdateResources(Turn turn)
        {

        }

        private void ProcessConflicts(Turn turn)
        {

        }
    }
}
