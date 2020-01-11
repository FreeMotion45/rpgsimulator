using RPGSimulator.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using TestBot;

namespace RPGSimulator.Bots
{
    class BotLoader
    {
        public List<IBot> LoadBots()
        {
            return new List<IBot>() { new BotSean(), new BotEmanuel() };
        }
    }
}
