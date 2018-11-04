using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Models.Moves;

namespace Services
{
    class GameService
    {
        public GameService(FactoryService factory, ISettingsService settings)
        {
            Factory = factory;
        }

        private FactoryService Factory { get; set; }

        private ISettingsService Settings { get; set; }

        public int GameId { get; set; }

        public GameState GameState { get; set; }

        

        public bool ProcessTurn(int playerId, List<int[]> moveData)
        {
            var moves = ParseMoves(moveData);
            if (CanValidateMoves(moves))
            {
                UpgradeBuildings(moves.Where(m => m is UpgradeBuilding) as List<UpgradeBuilding>);
            }
            
            //updatebuildings(turn);
            //updateresources(turn);
            //processconflicts(turn);
            return true;
        }

        private bool CanValidateMoves(List<IMove> moves)
        {
            return moves.All(m => m.IsValid(GameState));
        }

        private List<IMove> ParseMoves(List<int[]> moveData)
        {
            var parsedMoves = new List<IMove>();
            foreach (var move in moveData)
            {
                var parsedMove = Factory.MakeMove((MoveType)move[0]);
                parsedMove.Arguments = move.Skip(1).ToArray();
                parsedMoves.Add(parsedMove);
            }
            return parsedMoves;
        }

        private void UpgradeBuildings(List<UpgradeBuilding> moves)
        {

        }

        private void UpdateResources()
        {

        }

        private void ProcessConflicts()
        {

        }
    }
}
