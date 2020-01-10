using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts.Inventory;

namespace RPGSimulatorCommon.Character
{
    public interface ICharacter
    {
        Health Health { get; }
        Mana Mana { get; }
        IInventoryContent Inventory { get; }
    }
}
