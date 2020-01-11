using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs.Skills
{
    class ManaReduction : ISkillExtended
    {
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public void UseSkill(Character self, Character target)
        {
            target.ActualHealth.DecreaseHealth((int)(target.Health.CurrentHealth * 0.1));
            target.ActualMana.DecreaseMana(target.ActualMana.CurrentMana / 2);
        }
    }
}
