using System.Collections.Generic;

namespace RPGSimulatorCommon.Contracts
{
    public interface IInventoryContent
    {
        List<IUsable> Items { get; }

        List<IPotion> GetPotions();
    }
}
