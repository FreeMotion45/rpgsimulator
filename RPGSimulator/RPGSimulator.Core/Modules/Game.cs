using RPGSimulator.Common.Character;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Common.Character.Jobs.Skills;
using System;
using System.Collections.Generic;

namespace RPGSimulator.Core.Modules
{
    public class Game : IGameController
    {        
        public Game(ICharacter you, ICharacter enemy)
        {
            Self = you;
            Enemy = enemy;
            DidCurrentPlayerAct = false;
            GameState = GameState.Running;
        }
        public bool DidCurrentPlayerAct { get; private set; }

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
            DidCurrentPlayerAct = true;
        }        

        public void UseSkill(ISkill skill, ILimitedCharacter target)
        {
            ExceptIfAlreadyActed();
            if (ActualSelf.ActualJob.HasSkill(skill.Name))
            {
                ((SkillBase)(skill)).UseSkill(ActualSelf, target as Character);
                Console.WriteLine(Self + " used " + skill + " on " + target);
                DidCurrentPlayerAct = true;
            }
            else
            {
                throw new InvalidOperationException($"Player tried to use skill={skill.Name} but his job doesn't have this skill!");
            }
        }

        public void UseNormalAttack(ILimitedCharacter target)
        {
            ExceptIfAlreadyActed();
            (Self.Job as JobBase).Attack(ActualSelf, target as Character);
            Console.WriteLine(Self + " used normal attack on " + target);
            DidCurrentPlayerAct = true;
        }

        public void CyclePlayers()
        {
            ICharacter characterTemp = Self;
            Self = Enemy as ICharacter;
            Enemy = characterTemp;
        }

        private void ExceptIfAlreadyActed()
        {
            if (DidCurrentPlayerAct)
            {
                throw new InvalidOperationException("Bot tried to act more than once per turn!");
            }
        }
    }
}