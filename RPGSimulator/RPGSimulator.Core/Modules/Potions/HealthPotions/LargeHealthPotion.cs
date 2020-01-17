using RPGSimulator.Common.Character;
using RPGSimulator.Common.Potions.HealthPotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules.Potions.HealthPotions
{
    class LargeHealthPotion : HealthPotionBase
    {
        public LargeHealthPotion() : base("LargeHealth")
        {

        }

        protected override int CalculateHealingAmount(ICharacter target)
        {
            return (int) (0.5D * target.Health.MaxHealth);
        }
    }
}
