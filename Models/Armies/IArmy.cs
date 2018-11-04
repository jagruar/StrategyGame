using System;
using System.Collections.Generic;
using System.Text;
using Models.Traits;

namespace Models.Armies
{
    public interface IArmy
    {
        int ArmyId { get; set; }

        int PlayerId { get; set; }

        ResourceSet Cost { get; set; }

        ResourceSet Upkeep { get; set; }

        List<ITrait> Traits { get; set; }

        int _BaseAttack { get; set; }

        int _BaseDefence { get; set; }

        int Health { get; set; }
    }
}
