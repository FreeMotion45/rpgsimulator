using RPGSimulator.Common.Character.Jobs.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character.Jobs
{
    public interface IJob
    {
        JobType JobType { get; }
        ISkill SpecialAbility { get; }
        IEnumerable<ISkill> Skills { get; }
    }
}
