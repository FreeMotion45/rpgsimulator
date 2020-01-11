using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulatorCommon.Character;

namespace RPGSimulator.Core.Modules.States
{
    public class Mana : IMana
    {
        public Mana(int maxMana, int currentMana)
        {
            MaxMana = maxMana;
            CurrentMana = currentMana;
        }

        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }
    }
}
