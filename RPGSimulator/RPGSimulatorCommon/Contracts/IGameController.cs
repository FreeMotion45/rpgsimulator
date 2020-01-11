using RPGSimulator.Common.Character;
using RPGSimulatorCommon.Character.Jobs.Skills;

namespace RPGSimulator.Common.Contracts
{
    public interface IGameController
    {
        ICharacter Self { get; }
        ILimitedCharacter Enemy { get; }

        void UseSkillOnTarget(ISkill skill, ICharacter target);
        void UsePotionOnSelf(IPotion potion);
    }
}
