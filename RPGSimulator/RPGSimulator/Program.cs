using RPGSimulator.Core.Modules;
using RPGSimulator.Common.Character;
using RPGSimulator.Common.Character.States;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Common.Contracts.Inventory;
using RPGSimulator.Common.Potions.HealthPotions;
using RPGSimulator.Common.Potions.ManaPotions;
using RPGSimulator.Core.Modules.States;
using System;
using TestBot;
using RPGSimulator.Jobs;
using RPGSimulator.Core.Abstractions;

namespace RPGSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            JobFactory jobFactory = new JobFactory();
            IInventoryContent inventory = new Inventory();
            inventory.Items.Add(new SmallHealthPotion());
            inventory.Items.Add(new SmallManaPotion());

            Character character1 = new Character(
                new Health(100, 100),
                new Mana(80, 80),
                inventory);                            

            IGameController game = new Game(character1, null);
            
            IBot bot = new BotSean();
            character1.ActualJob = bot.ChooseJob(jobFactory) as JobBase;
            bot.DoTurn(game);
        }
    }
}
