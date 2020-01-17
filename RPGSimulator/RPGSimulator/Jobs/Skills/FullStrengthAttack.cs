using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs.Skills
{
    class FullStrengthAttack : SkillBase
    {
        public FullStrengthAttack(string name, string description) : base(name, description)
        {
        }

        public override void UseSkill(Character self, Character target)
        {
            int damage = Random.Next(self.ActualJob.MinimumDamage * 2, self.ActualJob.MaximumDamage * 2);
            target.ActualHealth.DecreaseHealth(damage);
        }
    }
}
