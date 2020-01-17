using RPGSimulator.Common.Character.Jobs.Skills;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs.Skills
{
    class HealthSteal : SkillBase
    {
        public HealthSteal(string description) : base(SkillName.HealthSteal, description)
        {
        }

        public override void UseSkill(Character self, Character target)
        {
            int minHealthSteal = (int) (self.ActualJob.MinimumDamage * 2.5);
            int maxHealthSteal = (int) (self.ActualJob.MinimumDamage * 2.5);

            Random random = new Random();
            int damage = random.Next(minHealthSteal, maxHealthSteal);

            self.ActualHealth.IncreaseHealth((int) (damage * 0.5));
            target.ActualHealth.DealDamage(damage);
        }
    }
}
