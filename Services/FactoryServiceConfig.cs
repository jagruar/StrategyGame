using System;
using System.Collections.Generic;
using System.Text;
using Models.Buildings;
using Models.Armies;
using Models.Moves;

namespace Services
{
    public class FactoryServiceConfig
    {
        public Dictionary<BuildingType, Type> BuildingsMap { get; set; }
        public Dictionary<ArmyType, Type> ArmiesMap { get; set; }
        public Dictionary<MoveType, Type> MovesMap { get; set; }

        public FactoryServiceConfig()
        {
            BuildingsMap = new Dictionary<BuildingType, Type>
            {
                { BuildingType.Farm, typeof(Farm) },
                { BuildingType.Mine, typeof(Mine) }
            };

            ArmiesMap = new Dictionary<ArmyType, Type>
            {
                { ArmyType.Peasant, typeof(Peasant) }
            };

            MovesMap = new Dictionary<MoveType, Type>
            {
                { MoveType.UpgradeBuilding, typeof(UpgradeBuilding) }
            };
        }        
    }
}
