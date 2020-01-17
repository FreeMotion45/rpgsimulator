using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Bots
{
    class Bot
    {        
        public Bot(Character character, IBot controller)
        {
            Character = character;
            Controller = controller;
            EnemyHistory = new List<Bot>();
        }

        public Character Character { get; }
        public IBot Controller { get; }
        public List<Bot> EnemyHistory { get; }
    }
}
