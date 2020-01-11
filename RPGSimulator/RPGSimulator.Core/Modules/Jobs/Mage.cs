using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;

namespace RPGSimulator.Core.Modules.Jobs
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
            self.ActualMana.MaxMana = (int)(self.Mana.MaxMana * 1.3);
            self.ActualMana.CurrentMana = self.Mana.MaxMana;
        }

        public void Attack(Character target)
        {
            target.ActualHealth.CurrentHealth -= CalculateAttackDamage();
        }

        public void UseSpecialAbility(Character target)
        {
            target.ActualHealth.CurrentHealth -= (int)(target.Health.CurrentHealth * 0.1);
            target.ActualMana.CurrentMana /= 2;
        }

        private int CalculateAttackDamage()
        {
            return random.Next(_minimumDamage, _maximumDamage);
        }
    }
}
