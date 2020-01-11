using RPGSimulator.Common.Character.States;
using RPGSimulatorCommon.Character.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character
{
    public interface ILimitedCharacter
    {
        IHealth Health { get; }

        IMana GetMana();

        IJob Job { get; }
    }
}
