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

        public void Remove(IUsable itemToRemove)
        {
            lock (_invLock)
            {
                _items.Remove(itemToRemove);
            }
        }

        public IUsable Pop(Type itemType)
        {
            lock (_invLock)
            {
                IUsable foundItem = _items.Find(item => item.GetType() == itemType);                
                return foundItem;
            }
        }

        public bool Exists(Type itemType)
        {
            lock (_invLock)
            {
                bool doesExist = _items.Exists(item => item.GetType() == itemType);
                return doesExist;
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
