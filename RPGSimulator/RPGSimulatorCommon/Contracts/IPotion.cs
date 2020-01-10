using RPGSimulatorCommon.Contracts.Inventory;
using RPGSimulatorCommon.Potions;

namespace RPGSimulatorCommon.Contracts
{
    public interface IPotion : IItem
    {
        PotionType PotionType { get; }
    }
}
