using RPGSimulator.Common.Character.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules.States
{
    public class Mana : IMana
    {
        public Mana(int maxMana, int currentMana)
        {
            MaxMana = maxMana;
            CurrentMana = currentMana;
        }

        public int MaxMana { get; private set; }
        public int CurrentMana { get; private set; }

        public void IncreaseMana(int amount)
        {
            CurrentMana += amount;

            if (CurrentMana > MaxMana)
            {
                CurrentMana = MaxMana;
            }
        }

        public void DecreaseMana(int amount)
        {
            CurrentMana -= amount;

            if (CurrentMana < 0)
            {
                CurrentMana = 0;
            }
        }

        public void IncreaseMaxMana(int maxMana)
        {
            MaxMana = maxMana;
        }
    }
}
