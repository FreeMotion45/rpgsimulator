using RPGSimulatorCommon.Potions;

namespace RPGSimulatorCommon.Contracts
{
    public interface IPotion : IUsable
    {
        PotionType PotionType { get; }
    }
}
