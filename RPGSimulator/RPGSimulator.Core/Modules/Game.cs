using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;
using System;

namespace RPGSimulator.Core.Modules
{
    public class Game : IGameController
    {
        public Game(CharacterState you, CharacterState enemy)
        {
            You = you;
            Enemy = enemy;
        }

        public CharacterState You { get; }

        public CharacterState Enemy { get; }

        public void UsePotion(IPotion potion)
        {
            potion.Use(You);
        }

        public void UseSkill()
        {
            throw new NotImplementedException();
        }
    }
}