using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;

namespace RPGSimulatorCommon.Potions.HealthPotions
{
    public abstract class HealthPotionBase : IPotion
    {
        public HealthPotionBase(string name="Health")
        {
            Name = name;
        }

        public PotionType PotionType => PotionType.Health;

        public string Name { get; }

        public void Use(ICharacter target)
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
