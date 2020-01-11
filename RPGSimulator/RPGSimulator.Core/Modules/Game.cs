using RPGSimulator.Common.Character;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Abstractions;
using RPGSimulatorCommon.Character.Jobs.Skills;
using System;

namespace RPGSimulator.Core.Modules
{
    public class Game : IGameController
    {
        public Game(ICharacter you, ICharacter enemy)
        {
            Self = you;
            Enemy = enemy;
        }

        public ICharacter Self { get; }

        public ILimitedCharacter Enemy { get; }

        public void UsePotionOnSelf(IPotion potion)
        {
            potion.Use(Self);
        }        

        public void UseSkillOnTarget(ISkill skill, ICharacter target)
        {
            ((SkillBase) (skill)).UseSkill(Self as Character, target as Character);
        }
    }
}