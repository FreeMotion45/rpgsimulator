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
        void Attack(Character target);
        void UseSpecialAbility(Character target);
        void AddBonusAttributes(Character self);
    }
}
