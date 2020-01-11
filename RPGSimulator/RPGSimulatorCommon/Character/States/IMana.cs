using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character.States
{
    public interface IMana
    {
        int CurrentMana { get; }
        int MaxMana { get; }
    }
}
