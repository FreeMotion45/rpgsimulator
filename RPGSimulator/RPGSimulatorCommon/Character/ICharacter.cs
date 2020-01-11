using RPGSimulatorCommon.Contracts.Inventory;

namespace RPGSimulatorCommon.Character
{
    public interface ICharacter
    {
        IHealth GetHealth { get; }
        IMana GetMana { get; }
        IInventoryContent Inventory { get; }
    }
}
