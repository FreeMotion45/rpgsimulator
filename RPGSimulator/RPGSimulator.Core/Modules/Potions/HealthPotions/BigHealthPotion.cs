using RPGSimulator.Common.Character;
using RPGSimulator.Common.Potions.HealthPotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules.Potions.HealthPotions
{
    class BigHealthPotion : HealthPotionBase
    {
        public BigHealthPotion() : base("BigHealth")
        {

        }
        protected override int CalculateHealingAmount(ICharacter target)
        {
            return 120;
        }
    }
}
