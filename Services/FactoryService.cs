using System;
using System.Collections.Generic;
using System.Text;
using Models.Buildings;
using Models.Armies;
using Models.Moves;

namespace Services
{
    class FactoryService
    {
        FactoryService()
        {
            Config = new FactoryServiceConfig();
        }

        private FactoryServiceConfig Config { get; set; }

        private ISettingsService Settings { get; set; }

        public IBuilding MakeBuilding(BuildingType buildingType)
        {
            var type = Config.BuildingsMap[buildingType];
            return (IBuilding)Activator.CreateInstance(type);
        }

        public IArmy MakeArmy(ArmyType armyType)
        {
            var type = Config.ArmiesMap[armyType];
            return (IArmy)Activator.CreateInstance(type);
        }

        public IMove MakeMove(MoveType moveType)
        {
            var type = Config.MovesMap[moveType];
            return (IMove)Activator.CreateInstance(type);
        }
    }
}
