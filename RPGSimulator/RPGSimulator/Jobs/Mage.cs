﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;

namespace RPGSimulator.Jobs
{
    public class Mage : IJob
    {
        public readonly int _minimumDamage;
        public readonly int _maximumDamage;
        public readonly Random random;

        public Mage()
        {
            _minimumDamage = 5;
            _maximumDamage = 11;
            random = new Random();
        }

        public void AddBonusAttributes(Character self)
        {
            self.Mana.MaxMana = (int) (self.Mana.MaxMana * 1.3);
            self.Mana.CurrentMana = self.Mana.MaxMana;
        }

        public void Attack(Character target)
        {
            target.Health.CurrentHealth -= CalculateAttackDamage();
        }

        public void UseSpecialAbility(Character target)
        {
            target.Health.CurrentHealth -= (int) (target.Health.CurrentHealth * 0.1);
            target.Mana.CurrentMana /= 2;
        }

        private int CalculateAttackDamage()
        {
            return random.Next(_minimumDamage, _maximumDamage);
        }
    }
}
