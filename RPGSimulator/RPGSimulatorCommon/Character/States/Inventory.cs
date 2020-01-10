using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character.States
{
    class Inventory
    {
        private readonly object _invLock;
        private readonly List<IUsable> _items;

        public Inventory(List<IUsable> items)
        {
            _invLock = new object();
            _items = items;
        }

        public void Add(IUsable item)
        {
            lock (_invLock)
            {
                _items.Add(item);
            }
        }

        internal void Remove(IUsable itemToRemove)
        {
            lock (_invLock)
            {
                _items.Remove(itemToRemove);
            }
        }

        public IEnumerable<IUsable> GetInventory()
        {
            lock (_invLock)
            {
                return _items;
            }
        }
    }
}
