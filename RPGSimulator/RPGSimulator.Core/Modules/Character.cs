using RPGSimulator.Common.Character;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Common.Contracts.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Character.States;

namespace RPGSimulator.Core.Modules
{
    public class Character : ICharacter
    {
        public Character(Health health, Mana mana, IInventoryContent inventory)
        {
            ActualHealth = health;
            ActualMana = mana;
            Inventory = inventory;
        }

        public Health ActualHealth { get; }

        public Mana ActualMana { get; }

        public IInventoryContent Inventory { get; }

        public IHealth Health { get => ActualHealth; }

        public IMana Mana { get => ActualMana; }
    }
}
