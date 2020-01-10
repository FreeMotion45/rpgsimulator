using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon
{
    class Game : IGameController
    {
        public Game(CharacterState you, CharacterState enemy)
        {
            You = you;
            Enemy = enemy;
        }

        public CharacterState You { get; }

        public CharacterState Enemy { get; }

        public void UsePotion()
        {
            throw new NotImplementedException();
        }

        public void UseSkill()
        {
            throw new NotImplementedException();
        }
    }
}
