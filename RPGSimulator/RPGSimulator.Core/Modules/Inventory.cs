using RPGSimulator.Core.Abstractions;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Modules
{
    public class Inventory : IInventory
    {
        public Inventory()
        {
            Items = new List<IUsable>();
        }

        public List<IUsable> Items { get; }

        public void AddItem(IUsable itemToAdd)
        {
            Items.Add(itemToAdd);
        }

        public List<IPotion> GetPotions()
        {
            return Items.Where(item => item.GetType() == typeof(IPotion)) as List<IPotion>;
        }

        public void RemoveItem(IUsable itemToRemove)
        {
            Items.Remove(itemToRemove);
        }
    }
}
