﻿using RPGSimulator.Common.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Potions.HealthPotions
{
    public class SmallHealthPotion : HealthPotionBase
    {
        public SmallHealthPotion() : base("SmallHealth")
        {

        }

        protected override int CalculateHealingAmount(ICharacter target)
        {
            return 20;
        }
    }
}
