using RPGSimulatorCommon.Character;

namespace RPGSimulatorCommon.Contracts
{
    public interface IUsable
    {
        void Use(ICharacter target);
    }
}
