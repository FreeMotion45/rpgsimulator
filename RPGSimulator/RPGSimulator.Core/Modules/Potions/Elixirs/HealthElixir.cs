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
    class HealthElixir : IPotion
    {
        public PotionType PotionType => PotionType.Elixir;

        public string Name => "HealthElixir";

        public void Use(ICharacter target)
        {
            Health characterHealth = target.Health as Health;
            Mana characterMana = target.Mana as Mana;

            characterHealth.IncreaseMaxHealth((int)(characterHealth.MaxHealth * 0.1D));
            characterHealth.IncreaseHealth((int)(characterHealth.MaxHealth * 0.5D));
            characterMana.IncreaseMana((int)(characterHealth.MaxHealth * 0.2D));
        }
    }
}
