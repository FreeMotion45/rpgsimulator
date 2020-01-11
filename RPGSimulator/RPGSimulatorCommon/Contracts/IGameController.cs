using RPGSimulator.Common.Character;

namespace RPGSimulator.Common.Contracts
{
    public interface IGameController
    {
        ICharacter Self { get; }
        ICharacter Enemy { get; }

        void UseSkill();
        void UsePotion(IPotion potion);
    }
}
