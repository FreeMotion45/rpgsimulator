using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Abstractions
{
    public interface ISkillExtended : ISkill
    {
        void UseSkill(Character self, Character target);
    }
}
