using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Character;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulator.Common.Character.Jobs;

namespace RPGSimulator.Core.Modules.Jobs
{
    public class Warrior : JobBase
    {
        public readonly Random _random;

        public Warrior(SkillBase skill) : base(skill, 8, 13, JobType.Warrior)
        {
            _random = new Random();
        }

        public override void AddBonusAttributes(Character self)
        {
            self.ActualHealth.IncreaseMaxHealth((int)(self.Health.MaxHealth * 1.2));
            self.ActualHealth.IncreaseHealth(self.ActualHealth.MaxHealth);
        }

        public override void Attack(Character self, Character target)
        {
            target.ActualHealth.DecreaseHealth(CalculateAttackDamage());
        }

        public override void UseSpecialAbility(Character self, Character target)
        {
            ActualSpecialAbility.UseSkill(self, target);
        }

        private int CalculateAttackDamage()
        {
            return _random.Next(MinimumDamage, MaximumDamage);
        }
    }
}
