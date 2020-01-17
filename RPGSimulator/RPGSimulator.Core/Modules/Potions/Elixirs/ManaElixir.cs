using RPGSimulator.Common.Character;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Common.Potions;
using RPGSimulator.Core.Modules.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules.Potions.Elixirs
{
    class ManaElixir : IPotion
    {
        public PotionType PotionType => PotionType.Elixir;

        public string Name => "ManaElixir";

        public void Use(ICharacter target)
        {
            Health characterHealth = target.Health as Health;
            Mana characterMana = target.Mana as Mana;

            characterMana.IncreaseMaxMana((int)(characterMana.MaxMana * 0.1D));
            characterMana.IncreaseMana((int)(characterMana.MaxMana * 0.5D));
            characterHealth.IncreaseHealth((int)(characterHealth.MaxHealth * 0.2D));
        }
    }
}
