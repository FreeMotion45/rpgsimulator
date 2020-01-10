using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character
{
    interface IMana
    {
        int MaxMana { get; internal set; }
        int CurrentMana { get; internal set; }
    }
}
