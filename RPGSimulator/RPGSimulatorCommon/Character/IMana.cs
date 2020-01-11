using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character
{
    public interface IMana
    {
        int MaxMana { get; }
        int CurrentMana { get; }
    }
}
