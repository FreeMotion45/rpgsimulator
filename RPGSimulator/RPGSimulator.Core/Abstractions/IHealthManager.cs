using RPGSimulatorCommon.Character.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Abstractions
{
    public interface IHealthManager : IHealth
    {
        void IncreaseHealth(int amount);
        void DecreaseHealth(int amount);
    }
}
