using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;
using RPGSimulatorCommon.Potions.HealthPotions;
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

        public void UsePotion(IPotion potion)
        {
            You.Inventory.Remove(potion);
            potion.Use(You);
        }

        public void UseSkill()
        {
            throw new NotImplementedException();
        }
    }
}
