using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character.States
{
    class Mana
    {
        public Mana(int maxMana, int currentMana)
        {
            MaxMana = maxMana;
            CurrentMana = currentMana;
        }

        public int MaxMana { get; }
        public int CurrentMana { get; }
    }
}
