using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character
{
    public class CharacterState
    {
        public Health Health { get; }
        public Mana Mana { get; }
        public Inventory Inventory { get; }
    }
}
