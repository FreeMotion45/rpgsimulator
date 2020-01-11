using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts.Inventory;

namespace RPGSimulatorCommon.Character
{
    public interface ICharacter
    {
        IHealth Health { get; }
        IMana Mana { get; }
        IInventoryContent Inventory { get; }
    }
}
