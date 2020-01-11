using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character.States
{
    public interface IHealth
    {
        int CurrentHealth { get; }
        int MaxHealth { get; }
    }
}
