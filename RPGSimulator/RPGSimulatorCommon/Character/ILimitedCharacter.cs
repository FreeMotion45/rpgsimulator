using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Character.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character
{
    public interface ILimitedCharacter
    {
        string Name { get; }

        IHealth Health { get; }

        IMana Mana { get; }

        IJob Job { get; }
    }
}
