﻿
namespace RPGSimulator.Common.Potions.ManaPotions
{
    public class SmallManaPotion : ManaPotionBase
    {
        protected override int CalculateManaAmount()
        {
            return 20;
        }
    }
}
