using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs.Skills
{
    class ManaReduction : SkillBase
    {
        public ManaReduction(string name, string description) : base(name, description)
        {
        }

        public override void UseSkill(Character self, Character target)
        {
            target.ActualHealth.DecreaseHealth((int)(target.Health.CurrentHealth * 0.1));
            target.ActualMana.DecreaseMana(target.ActualMana.CurrentMana / 2);
        }
    }
}
