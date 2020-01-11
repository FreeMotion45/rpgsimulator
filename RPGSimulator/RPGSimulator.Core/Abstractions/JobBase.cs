using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs;
using RPGSimulatorCommon.Character.Jobs.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Abstractions
{
    public abstract class JobBase : IJob
    {
        public JobBase(SkillBase skill, int minimumDamage, int maximumDamage, JobType jobType)
        {
            Skill = skill;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            JobType = jobType;
        }

        public SkillBase Skill { get; }
        public int MinimumDamage { get; }
        public int MaximumDamage { get; }
        public JobType JobType { get; }

        public ISkill SpecialAbility { get => Skill; }

        public abstract void Attack(Character self, Character target);
        public abstract void UseSpecialAbility(Character self, Character target);
        public abstract void AddBonusAttributes(Character self);
    }
}
