using RPGSimulator.Common.Character;
using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Modules.States;

namespace RPGSimulator.Common.Potions.ManaPotions
{
    public abstract class ManaPotionBase : IPotion
    {
        public ManaPotionBase(string name="Mana")
        {
            Name = name;
        }

        public PotionType PotionType => PotionType.Mana;

        public string Name { get; }

        public void Use(ICharacter target)
        {
            Mana characterMana = target.Mana as Mana;
            characterMana.IncreaseMana(CalculateManaAmount(target));
        }        

        protected abstract int CalculateManaAmount(ICharacter target);

        public override string ToString()
        {
            return "ManaPotion";
        }
    }
}
