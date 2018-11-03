using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IBuilding
    {
        BuildingTypes BuildingType { get; set; }

        BuildingBranchTypes BuildingBranchType { get; set; }

        int Level { get; set; }

        ResourceSet Cost { get; set; }

        ResourceSet Gain { get; set; }
    }
}
