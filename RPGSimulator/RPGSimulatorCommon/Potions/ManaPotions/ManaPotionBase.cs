using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;

namespace RPGSimulatorCommon.Potions.ManaPotions
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
            Mana characterMana = target.GetMana;

            characterMana.CurrentMana += CalculateManaAmount();

            if (characterMana.CurrentMana > characterMana.MaxMana)
            {
                characterMana.CurrentMana = characterMana.MaxMana;
            }
        }        

        protected abstract int CalculateManaAmount();
    }
}
