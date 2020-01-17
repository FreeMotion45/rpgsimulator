using RPGSimulator.Common.Character;
using RPGSimulator.Common.Character.Jobs.Skills;

namespace RPGSimulator.Common.Contracts
{
    public interface IGameController
    {
        ICharacter Self { get; }
        ILimitedCharacter Enemy { get; }

        void UseNormalAttack(ILimitedCharacter target);
        void UseSkill(ISkill skill, ILimitedCharacter target);
        void UsePotionOnSelf(IPotion potion);
    }
}
