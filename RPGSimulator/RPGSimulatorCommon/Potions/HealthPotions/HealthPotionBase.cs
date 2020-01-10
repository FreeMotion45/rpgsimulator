﻿using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Potions.HealthPotions
{
    abstract class HealthPotionBase : IPotion
    {
        public PotionType PotionType => PotionType.Health;

        public void Use(CharacterState target)
        {
            Health characterHealth = target.Health;

            characterHealth.CurrentHealth += CalculateHealingAmount();

            if (characterHealth.CurrentHealth > characterHealth.MaxHealth)
            {
                characterHealth.CurrentHealth = characterHealth.MaxHealth;
            }
        }

        protected abstract int CalculateHealingAmount();
    }
}
