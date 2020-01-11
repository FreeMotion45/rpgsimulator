using RPGSimulator.Core.Abstractions;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Common.Contracts.Inventory;
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

        public void RemoveItem(IItem itemToRemove)
        {
            Items.Remove(itemToRemove);
        }

        public List<IPotion> GetPotions()
        {
            return Items.Where(item => item is IPotion).Select(item => item as IPotion).ToList();
        }
    }
}
