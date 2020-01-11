using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Abstractions
{
    public interface IJobExtended : IJob
    {
        void Attack(Character self, Character target);
        void UseSpecialAbility(Character self, Character target);
        void AddBonusAttributes(Character self);
        
        SkillBase Skill { get; }
        int MinimumDamage { get; }
        int MaximumDamage { get; }
    }
}
