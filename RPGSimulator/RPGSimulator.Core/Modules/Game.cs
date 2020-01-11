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
        private bool _didAct;

        public Game(ICharacter you, ICharacter enemy)
        {
            Self = you;
            Enemy = enemy;
            _didAct = false;
            GameState = GameState.Ready;
        }

        public ICharacter Self { get; }
        public Character ActualSelf { get => Self as Character; }

        public ILimitedCharacter Enemy { get; }   
        public Character ActualEnemy { get => Enemy as Character; }
        
        public GameState GameState { get; set; }

        public void UsePotionOnSelf(IPotion potion)
        {
            ExceptIfAlreadyActed();
            potion.Use(Self);
            _didAct = true;
            EvaluateGameState();
        }        

        public void UseSkill(ISkill skill, ILimitedCharacter target)
        {
            ExceptIfAlreadyActed();
            ((SkillBase) (skill)).UseSkill(ActualSelf, target as Character);
            _didAct = true;
            EvaluateGameState();
        }

        public void NormalAttack(ILimitedCharacter target)
        {
            ExceptIfAlreadyActed();
            (Self.Job as JobBase).Attack(ActualSelf, target as Character);
            _didAct = true;
            EvaluateGameState();
        }

        private void ExceptIfAlreadyActed()
        {
            if (_didAct)
            {
                throw new InvalidOperationException("Bot tried to act more than once per turn!");
            }
        }

        private void EvaluateGameState()
        {
            if (Enemy.Health.CurrentHealth == 0 || Self.Health.CurrentHealth == 0)
            {
                GameState = GameState.Finished;
            }

            _didAct = false;
        }
    }
}