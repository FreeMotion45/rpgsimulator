using RPGSimulatorCommon.Contracts;

namespace RPGSimulator.Core.Abstractions
{
    public interface IInventory : IInventoryContent
    {
        void AddItem(IUsable itemToAdd);
        void RemoveItem(IUsable itemToRemove);
    }
}
