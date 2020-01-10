using RPGSimulatorCommon.Character;

namespace RPGSimulatorCommon.Contracts
{
    public interface IGameController
    {
        ICharacter Self { get; }
        ICharacter Enemy { get; }

        void UseSkill();
        void UsePotion(IPotion potion);
    }
}
