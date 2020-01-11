using RPGSimulator.Common.Character.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules.States
{
    public class Health : IHealth
    {
        public Health(int maxHealth, int currentHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
        }

        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }

        public void IncreaseHealth(int amount)
        {
            CurrentHealth += amount;

            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }

        public void DecreaseHealth(int amount)
        {
            CurrentHealth -= amount;

            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public void IncreaseMaxHealth(int maxHealth)
        {
            MaxHealth = maxHealth;
        }        
    }
}
