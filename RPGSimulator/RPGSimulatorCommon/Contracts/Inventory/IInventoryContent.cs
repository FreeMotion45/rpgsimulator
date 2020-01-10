using System.Collections.Generic;

namespace RPGSimulatorCommon.Contracts.Inventory
{
    public interface IInventoryContent
    {
        List<IItem> Items { get; }

        List<IPotion> GetPotions();
    }
}
