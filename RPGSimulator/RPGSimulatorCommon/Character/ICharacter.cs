using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts.Inventory;

namespace RPGSimulator.Common.Character
{
    public interface ICharacter
    {
        Health Health { get; }
        Mana Mana { get; }
        IInventoryContent Inventory { get; }
    }
}
