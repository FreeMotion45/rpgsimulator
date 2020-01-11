using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs.Skills;

namespace RPGSimulator.Core.Abstractions
{
    public abstract class SkillBase : ISkill
    {
        protected Random Random;
        protected SkillBase(string name, string description)
        {
            Name = name;
            Description = description;
            Random = new Random();
        }

        public string Name { get; }

        public string Description { get; }

        public abstract void UseSkill(Character self, Character target);
    }
}
