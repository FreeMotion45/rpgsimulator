using RPGSimulatorCommon.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Contracts
{
    interface IGameController
    {
        CharacterState You { get; }
        CharacterState Enemy { get; }

        void UseSkill();
        void UsePotion();
    }
}
