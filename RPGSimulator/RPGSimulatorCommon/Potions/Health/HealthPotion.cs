using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Potions.Health
{
    abstract class HealthPotion : IPotion
    {
        public PotionType PotionType => PotionType.Health;

        public void Use(CharacterState characterState)
        {
            Health characterHealth = characterState.Health;

            characterHealth.CurrentHealth += CalculateHealingAmount();

            if (characterHealth.CurrentHealth > characterHealth.MaxHealth)
            {
                characterHealth.CurrentHealth = characterHealth.MaxHealth;
            }
        }

        protected abstract int CalculateHealingAmount();
    }
}
