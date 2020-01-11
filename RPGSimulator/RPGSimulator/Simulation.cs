using RPGSimulator.Bots;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator
{
    class Simulation
    {
        public IBot Bot1 { get; }
        public IBot Bot2 { get; }
        public JobFactory JobFactory { get; }

        public Simulation(IBot bot1, IBot bot2, JobFactory jobFactory)
        {
            Bot1 = bot1;
            Bot2 = bot2;
            JobFactory = jobFactory;
        }

        public void Run()
        {
            List<Bot> bots = CreateBots();
            Bot starter = ChooseStarter(bots);
            List<Bot> otherBots = FindOtherBots(starter, bots);

            Game game = new Game(starter.Character, otherBots[0].Character);  
            
            while (game.GameState != GameState.Finished)
            {
                Bot currentBot = bots.Find(bot => game.ActualSelf == bot.Character);
                currentBot.Controller.DoTurn(game);
                game.CyclePlayers();                
            }

            Console.WriteLine(FindWinner(bots).Character + " has won the game!");
        }

        private Bot FindWinner(List<Bot> bots)
        {
            return bots.Find(bot => bot.Character.Health.CurrentHealth > 0);
        }

        private List<Bot> FindOtherBots(Bot starter, List<Bot> bots)
        {
            List<Bot> otherBots = new List<Bot>();

            foreach (var bot in bots)
            {
                if (bot != starter)
                {
                    otherBots.Add(bot);
                }
            }

            return otherBots;
        }

        private Bot ChooseStarter(List<Bot> bots)
        {
            Random random = new Random();
            return bots[random.Next(1, 2)];
        }

        private List<Bot> CreateBots()
        {
            List<Bot> bots = new List<Bot>();

            Character bot1Character = new Character(Bot1.ChooseName(),
                                        new Health(200, 200),
                                        new Mana(100, 100),
                                        new Inventory())
            {
                ActualJob = Bot1.ChooseJob(JobFactory) as JobBase
            };

            bots.Add(new Bot(bot1Character, Bot1));

            Character bot2Character = new Character(Bot2.ChooseName(),
                                        new Health(200, 200),
                                        new Mana(100, 100),
                                        new Inventory())
            {
                ActualJob = Bot2.ChooseJob(JobFactory) as JobBase
            };

            bots.Add(new Bot(bot2Character, Bot2));
            return bots;
        }
    }
}
