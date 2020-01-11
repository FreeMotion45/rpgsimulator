using RPGSimulator.Common.Character;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Common.Contracts;

namespace RPGSimulator.Common.Potions.HealthPotions
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
            Health characterHealth = target.Health as Health;
            characterHealth.IncreaseHealth(CalculateHealingAmount());
        }

        protected abstract int CalculateHealingAmount();
    }
}
