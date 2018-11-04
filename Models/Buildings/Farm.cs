using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Buildings
{
    public class Farm : IBuilding
    {
        public BuildingType BuildingType => BuildingType.Farm;
        public BuildingBranchType BuildingBranchType => BuildingBranchType.Basic;
        public int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceSet Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceSet Gain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
