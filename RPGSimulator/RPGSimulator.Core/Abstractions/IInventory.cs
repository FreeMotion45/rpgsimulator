using RPGSimulatorCommon.Contracts;
using RPGSimulatorCommon.Contracts.Inventory;

namespace RPGSimulator.Core.Abstractions
{
    public interface IInventory : IInventoryContent
    {
        void AddItem(IItem itemToAdd);
        void RemoveItem(IItem itemToRemove);
    }
}
