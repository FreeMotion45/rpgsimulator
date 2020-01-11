using RPGSimulator.Core.Abstractions;
using RPGSimulatorCommon.Character.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules.States
{
    public class Health : IHealthManager
    {
        public Health(int currentHealth, int maxHealth)
        {
            CurrentHealth = currentHealth;
            MaxHealth = maxHealth;
        }

        public int CurrentHealth { get; }

        public int MaxHealth { get; }

        public void DecreaseHealth(int amount)
        {
            throw new NotImplementedException();
        }

        public void IncreaseHealth(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
