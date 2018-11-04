using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Buildings
{
    public interface IBuilding
    {
        BuildingType BuildingType { get; }

        BuildingBranchType BuildingBranchType { get; }

        int Level { get; set; }

        ResourceSet Cost { get; set; }

        ResourceSet Gain { get; set; }


    }
}
