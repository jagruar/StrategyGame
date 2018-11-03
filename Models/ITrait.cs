using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface ITrait
    {
        bool ShouldApply();

        bool Apply();
    }
}
