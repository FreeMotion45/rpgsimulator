using RPGSimulator.Common.Character;

namespace RPGSimulator.Common.Contracts
{
    public interface IUsable
    {
        void Use(ICharacter target);
    }
}
