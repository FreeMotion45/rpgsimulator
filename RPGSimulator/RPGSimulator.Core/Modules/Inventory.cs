using RPGSimulator.Core.Abstractions;
using RPGSimulatorCommon.Contracts;
using RPGSimulatorCommon.Contracts.Inventory;
using System.Collections.Generic;
using System.Linq;

namespace RPGSimulator.Core.Modules
{
    public class Inventory : IInventory
    {
        public Inventory()
        {
            Items = new List<IItem>();
        }

        public List<IItem> Items { get; }

        public void AddItem(IItem itemToAdd)
        {
            Items.Add(itemToAdd);
        }

        public List<IPotion> GetPotions()
        {
            return Items.Where(item => item.GetType() == typeof(IPotion)) as List<IPotion> ?? new List<IPotion>();
        }

        public void RemoveItem(IItem itemToRemove)
        {
            Items.Remove(itemToRemove);
        }
    }
}
