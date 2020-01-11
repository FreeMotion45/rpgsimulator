using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs;

namespace RPGSimulator.Core.Modules.Jobs
{
    public class Mage : IJobExtended
    {
        public readonly Random random;

        public Mage()
        {
            MinimumDamage = 5;
            MaximumDamage = 11;
            random = new Random();
        }

        public JobType JobType => JobType.Mage;

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public SkillBase Skill { get; set; }

        public void AddBonusAttributes(Character self)
        {
            self.ActualMana.IncreaseMaxMana((int)(self.Mana.MaxMana * 1.3));
            self.ActualMana.IncreaseMana(self.ActualMana.MaxMana);           
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
