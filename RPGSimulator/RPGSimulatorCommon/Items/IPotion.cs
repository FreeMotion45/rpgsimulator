using RPGSimulator.Common.Contracts.Inventory;
using RPGSimulator.Common.Potions;

namespace RPGSimulator.Common.Contracts
{
    public interface IPotion : IItem
    {
        PotionType PotionType { get; }
    }
}
