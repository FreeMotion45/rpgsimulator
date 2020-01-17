using RPGSimulatorCommon.Character.Jobs.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character.Jobs
{
    public interface IJob
    {
        JobType JobType { get; }
        ISkill SpecialAbility { get; }
    }
}
