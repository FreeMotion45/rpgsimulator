using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Potions.HealthPotions
{
    public class SmallHealthPotion : HealthPotionBase
    {
        public SmallHealthPotion() : base("Small Health")
        {

        }

        protected override int CalculateHealingAmount()
        {
            return 20;
        }
    }
}
