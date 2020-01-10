using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Potions.HealthPotions
{
    public class SmallHealthPotion : HealthPotionBase
    {
        protected override int CalculateHealingAmount()
        {
            return 20;
        }
    }
}
