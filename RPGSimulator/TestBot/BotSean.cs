﻿using RPGSimulatorCommon.Contracts;
using System.Linq;

namespace TestBot
{
    public class BotSean : IBot
    {
        public void DoTurn(IGameController game)
        {
            foreach (var item in game.Self.Inventory.GetPotions())
            {
                System.Console.WriteLine("Potion name: {0}, Potion type: {1}", item.Name, item.PotionType);
            }
        }
    }
}