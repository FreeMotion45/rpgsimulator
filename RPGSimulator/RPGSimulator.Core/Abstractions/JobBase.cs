using RPGSimulator.Core.Modules;
using RPGSimulator.Common.Character.Jobs;
using RPGSimulator.Common.Character.Jobs.Skills;
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
            ActualSpecialAbility = skill;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            JobType = jobType;
        }

        public int MinimumDamage { get; }
        public int MaximumDamage { get; }
        public JobType JobType { get; }

        public List<SkillBase> ActualSkills { get; }
        public IEnumerable<ISkill> Skills { get => ActualSkills; }

        public SkillBase ActualSpecialAbility { get; }
        public ISkill SpecialAbility { get => ActualSpecialAbility; }
        
        public abstract void Attack(Character self, Character target);
        public abstract void UseSpecialAbility(Character self, Character target);
        public abstract void AddBonusAttributes(Character self);

        public bool HasSkill(SkillName skillName)
        {
            return ActualSkills.Find(skill => skill.Name == skillName) != null;
        }

        public ISkill GetSkill(SkillName skillName)
        {
            if (HasSkill(skillName))
            {
                return ActualSkills.Find(skill => skill.Name == skillName);
            }
            else
            {
                throw new InvalidOperationException($"Character with job={JobType} doesn't have skill where name={skillName}");
            }
        }

        public override string ToString()
        {
            return JobType.ToString();
        }
    }
}
