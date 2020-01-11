using RPGSimulator.Common.Character;
using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts;

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
            Mana characterMana = target.Mana;

            characterMana.CurrentMana += CalculateManaAmount();

            if (characterMana.CurrentMana > characterMana.MaxMana)
            {
                characterMana.CurrentMana = characterMana.MaxMana;
            }
        }        

        protected abstract int CalculateManaAmount();
    }
}
