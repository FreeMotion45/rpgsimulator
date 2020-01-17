using RPGSimulator.Common.Character;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Common.Contracts.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Character.States;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Common.Character.Jobs;

namespace RPGSimulator.Core.Modules
{
    public class Character : ICharacter
    {
        public Character(string name, Health health, Mana mana, IJob job, IInventoryContent inventory)
        {
            Name = name;
            ActualHealth = health;
            ActualMana = mana;
            Inventory = inventory;
            ActualJob = job as JobBase;
        }

        public string Name { get; }

        public Health ActualHealth { get; set; }

        public Mana ActualMana { get; set; }

        public JobBase ActualJob { get; set; }

        public IInventoryContent Inventory { get; }

        public IHealth Health { get => ActualHealth; }

        public IMana Mana { get => ActualMana; }

        public IJob Job { get => ActualJob; }

        public override string ToString()
        {
            return Name;
        }
    }
}
