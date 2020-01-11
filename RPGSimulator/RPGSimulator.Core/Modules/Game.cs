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
            GameState = GameState.Running;
        }

        public ICharacter Self { get; set; }
        public Character ActualSelf { get => Self as Character; }

        public ILimitedCharacter Enemy { get; set; }   
        public Character ActualEnemy { get => Enemy as Character; }
        
        public GameState GameState { get; set; }

        public void UsePotionOnSelf(IPotion potion)
        {
            ExceptIfAlreadyActed();
            potion.Use(Self);
            Console.WriteLine(Self + " drank " + potion);
            _didAct = true;
            EvaluateGameState();
        }        

        public void UseSkill(ISkill skill, ILimitedCharacter target)
        {
            ExceptIfAlreadyActed();
            ((SkillBase) (skill)).UseSkill(ActualSelf, target as Character);
            Console.WriteLine(Self + " used " + skill + " on " + target);
            _didAct = true;
            EvaluateGameState();
        }

        public void UseNormalAttack(ILimitedCharacter target)
        {
            ExceptIfAlreadyActed();
            (Self.Job as JobBase).Attack(ActualSelf, target as Character);
            Console.WriteLine(Self + " used normal attack on " + target);
            _didAct = true;
            EvaluateGameState();
        }

        public void CyclePlayers()
        {
            ICharacter characterTemp = Self;
            Self = Enemy as ICharacter;
            Enemy = characterTemp;
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