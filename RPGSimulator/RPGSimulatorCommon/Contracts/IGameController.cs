using RPGSimulator.Common.Character;
using RPGSimulatorCommon.Character.Jobs.Skills;

namespace RPGSimulator.Common.Contracts
{
    public interface IGameController
    {
        ICharacter Self { get; }
        ILimitedCharacter Enemy { get; }

        void NormalAttack(ILimitedCharacter target);
        void UseSkill(ISkill skill, ILimitedCharacter target);
        void UsePotionOnSelf(IPotion potion);
    }
}
