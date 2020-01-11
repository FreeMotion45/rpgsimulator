using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts.Inventory;

namespace RPGSimulator.Common.Character
{
    public interface ICharacter
    {
        IHealth Health { get; }
        IMana Mana { get; }
        IInventoryContent Inventory { get; }
    }
}
