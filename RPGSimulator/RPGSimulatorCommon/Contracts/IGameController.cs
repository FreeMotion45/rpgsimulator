using RPGSimulator.Common.Character;
using RPGSimulatorCommon.Character.Jobs.Skills;

namespace RPGSimulator.Common.Contracts
{
    public interface IGameController
    {
        ICharacter Self { get; }
        ILimitedCharacter Enemy { get; }

        void NormalAttack(ICharacter target);
        void UseSkill(ISkill skill, ICharacter target);
        void UsePotionOnSelf(IPotion potion);
    }
}
