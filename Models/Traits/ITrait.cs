using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Traits
{
    public interface ITrait
    {
        bool ShouldApply();

        bool Apply();
    }
}
