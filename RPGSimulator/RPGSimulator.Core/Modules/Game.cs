using RPGSimulator.Common.Character;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules.States;
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
            GameState = GameState.Ready;
        }

        public ICharacter Self { get; }
        public Character ActualSelf { get => Self as Character; }

        public ILimitedCharacter Enemy { get; }   
        public Character ActualEnemy { get => Enemy as Character; }
        
        public GameState GameState { get; set; }

        public void UsePotionOnSelf(IPotion potion)
        {
            potion.Use(Self);
        }        

        public void UseSkill(ISkill skill, ICharacter target)
        {
            ((SkillBase) (skill)).UseSkill(ActualSelf, target as Character);
        }

        public void NormalAttack(ICharacter target)
        {
            (Self.Job as JobBase).Attack(ActualSelf, target as Character);
        }
    }
}