using RPGSimulator.Common.Character.Jobs.Skills;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs.Skills
{
    class FullStrengthAttack : SkillBase
    {
        public FullStrengthAttack(string description) : base(SkillName.FullStrengthAttack, description)
        {
        }

        public override void UseSkill(Character self, Character target)
        {
            int damage = Random.Next(self.ActualJob.MinimumDamage * 2, self.ActualJob.MaximumDamage * 2);
            target.ActualHealth.DealDamage(damage - target.Job.Defense);
        }
    }
}
