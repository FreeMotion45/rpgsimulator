using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Potions.ManaPotions
{
    public class SmallManaPotion : ManaPotionBase
    {
        protected override int CalculateManaAmount()
        {
            return 20;
        }
    }
}
