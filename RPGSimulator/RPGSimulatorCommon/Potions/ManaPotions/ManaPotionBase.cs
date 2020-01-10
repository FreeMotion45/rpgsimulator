using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Potions.ManaPotions
{
    abstract class ManaPotionBase : UsableBase
    {
        public PotionType PotionType => PotionType.Mana;

        public CharacterState Owner { get; internal set; }

        protected override void EffectOwner()
        {
            Mana characterMana = Owner.Mana;

            characterMana.CurrentMana += CalculateManaAmount();

            if (characterMana.CurrentMana > characterMana.MaxMana)
            {
                characterMana.CurrentMana = characterMana.MaxMana;
            }
        }        

        protected abstract int CalculateManaAmount();
    }
}
