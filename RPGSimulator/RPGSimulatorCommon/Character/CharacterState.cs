using RPGSimulatorCommon.Character.States;
using RPGSimulatorCommon.Contracts;

namespace RPGSimulatorCommon.Character
{
    public class CharacterState
    {
        public Health Health { get; }
        public Mana Mana { get; }
        public IInventoryContent Inventory { get; }
    }
}
