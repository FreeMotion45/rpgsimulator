using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character.States
{
    public class Mana
    {
        public Mana(int maxMana, int currentMana)
        {
            MaxMana = maxMana;
            CurrentMana = currentMana;
        }

        public int MaxMana { get; internal set; }
        public int CurrentMana { get; internal set; }
    }
}
