using System.Collections.Generic;

namespace RPGSimulator.Common.Contracts.Inventory
{
    public interface IInventoryContent
    {
        List<IItem> Items { get; }

        List<IPotion> GetPotions();
    }
}
