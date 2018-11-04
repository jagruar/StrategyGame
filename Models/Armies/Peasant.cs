using System;
using System.Collections.Generic;
using System.Text;
using Models.Traits;

namespace Models.Armies
{
    public class Peasant : IArmy
    {
        public int ArmyId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PlayerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceSet Cost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ResourceSet Upkeep { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ITrait> Traits { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _BaseAttack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int _BaseDefence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
