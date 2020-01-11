﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulatorCommon.Character;

namespace RPGSimulator.Core.Modules.States
{
    public class Health : IHealth
    {
        public Health(int maxHealth, int currentHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
        }

        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
    }
}
