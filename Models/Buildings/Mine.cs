using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Buildings
{
    public class Mine : IBuilding
    {
        public BuildingType BuildingType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public BuildingBranchType BuildingBranchType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceSet Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceSet Gain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
