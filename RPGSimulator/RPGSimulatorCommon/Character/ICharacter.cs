using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts.Inventory;
using RPGSimulator.Common.Character.Jobs;

namespace RPGSimulator.Common.Character
{
    public interface ICharacter : ILimitedCharacter
    {        
        IInventoryContent Inventory { get; }
    }
}
