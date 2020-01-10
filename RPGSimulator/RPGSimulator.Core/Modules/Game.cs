using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;
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

        public ICharacter Enemy { get; }

        public void UsePotion(IPotion potion)
        {
            potion.Use(Self);
        }

        public void UseSkill()
        {
            throw new NotImplementedException();
        }
    }
}