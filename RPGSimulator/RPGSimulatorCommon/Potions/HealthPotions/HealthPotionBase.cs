using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Potions.HealthPotions
{
    abstract class HealthPotionBase : UsableBase
    {
        public PotionType PotionType => PotionType.Health;

        public CharacterState Owner { get; internal set; }

        protected override void EffectOwner()
        {
            Health characterHealth = Owner.Health;

            characterHealth.CurrentHealth += CalculateHealingAmount();

            if (characterHealth.CurrentHealth > characterHealth.MaxHealth)
            {
                characterHealth.CurrentHealth = characterHealth.MaxHealth;
            }
        }

        protected abstract int CalculateHealingAmount();
    }
}
