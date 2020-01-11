using RPGSimulatorCommon.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Contracts
{
    public interface IJob
    {
        JobType Type { get; }
    }
}
