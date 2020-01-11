using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs.Skills
{
    class FullStrengthAttack : ISkillExtended
    {
        private Random random;

        public FullStrengthAttack(Random random)
        {
            this.random = random;
        }

        public string Name => "Full strength attack";

        public string Description => "Attacks with double the power of a normal attack.";

        public void UseSkill(Character self, Character target)
        {
            int damage = random.Next(self.ActualJob.MinimumDamage * 2, self.ActualJob.MaximumDamage * 2);

        }
    }
}
