using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Character.Jobs.Skills;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Modules;

namespace RPGSimulator.Core.Abstractions
{
    public abstract class SkillBase : ISkill
    {
        protected Random Random;
        protected SkillBase(SkillName name, string description)
        {
            Name = name;
            Description = description;
            Random = new Random();
        }

        public SkillName Name { get; }

        public string Description { get; }

        public abstract void UseSkill(Character self, Character target);
    }
}
