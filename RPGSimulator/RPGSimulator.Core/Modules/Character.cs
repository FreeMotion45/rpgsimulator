using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules
{
    public class Character : ICharacter
    {
        public Character(IHealth health, IMana mana, IInventoryContent inventory)
        {
            Health = health;
            Mana = mana;
            Inventory = inventory;
        }

        public IHealth Health { get; }

        public IMana Mana { get; }

        public IInventoryContent Inventory { get; }
    }
}
