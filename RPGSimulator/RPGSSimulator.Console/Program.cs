using RPGSimulator.Core.Modules;
using RPGSimulator.Core.Modules.States;
using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;
using RPGSimulatorCommon.Contracts.Inventory;
using RPGSimulatorCommon.Potions.HealthPotions;
using RPGSimulatorCommon.Potions.ManaPotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBot;

namespace RPGSSimulator.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IInventoryContent inventory = new Inventory();
            inventory.Items.Add(new SmallHealthPotion());
            inventory.Items.Add(new SmallManaPotion());

            ICharacter character1 = new Character(
                new Health(100, 100),
                new Mana(80, 80),
                inventory);

            IGameController game = new Game(character1, null);

            IBot bot = new BotSean();
            bot.DoTurn(game);
        }
    }
}
