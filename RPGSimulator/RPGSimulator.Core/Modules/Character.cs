using RPGSimulatorCommon.Character;
using RPGSimulator.Core.Modules.States;
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
        public Character(Health health, Mana mana, IInventoryContent inventory)
        {
            Health = health;
            Mana = mana;
            Inventory = inventory;
        }

        public Health Health { get; }

        public Mana Mana { get; }

        public IInventoryContent Inventory { get; }
    }
}
