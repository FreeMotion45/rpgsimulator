using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Character;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs;

namespace RPGSimulator.Core.Modules.Jobs
{
    public class Warrior : IJobExtended
    {
        public readonly Random random;

        public Warrior()
        {
            random = new Random();
        }

        public JobType JobType => JobType.Warrior;

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public SkillBase Skill { get; set; }

        public void AddBonusAttributes(Character self)
        {
            self.ActualHealth.IncreaseMaxHealth((int)(self.Health.MaxHealth * 1.2));
            self.ActualHealth.IncreaseHealth(self.ActualHealth.MaxHealth);
        }

        public void Attack(Character self, Character target)
        {
            target.ActualHealth.DecreaseHealth(CalculateAttackDamage());
        }

        public void UseSpecialAbility(Character self, Character target)
        {
            Skill.UseSkill(self, target);
        }

        private int CalculateAttackDamage()
        {
            return random.Next(MinimumDamage, MaximumDamage);
        }
    }
}
