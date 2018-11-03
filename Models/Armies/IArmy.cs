using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IArmy
    {
        int PlayerId { get; set; }

        ResourceSet Cost { get; set; }

        ResourceSet Upkeep { get; set; }

        List<ITrait> Traits { get; set; }

        int _BaseAttack { get; set; }

        int _BaseDefence { get; set; }

        int Health { get; set; }
    }
}
