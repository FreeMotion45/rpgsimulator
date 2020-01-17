using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts.Inventory;
using RPGSimulatorCommon.Character.Jobs;

namespace RPGSimulator.Common.Character
{
    public interface ICharacter : ILimitedCharacter
    {        
        IInventoryContent Inventory { get; }
    }
}
