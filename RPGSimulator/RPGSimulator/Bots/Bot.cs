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
        }

        public Character Character { get; }
        public IBot Controller { get; }
    }
}
