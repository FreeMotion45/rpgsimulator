using RPGSimulator.Common.Contracts;
using RPGSimulator.Common.Contracts.Inventory;

namespace RPGSimulator.Core.Abstractions
{
    public interface IInventory : IInventoryContent
    {
        void AddItem(IItem itemToAdd);
        void RemoveItem(IItem itemToRemove);
    }
}
