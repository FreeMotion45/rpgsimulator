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
    class SimulationRunner
    {
        public SimulationRunner(List<IBot> bots, JobFactory jobFactory)
        {
            Bots = bots;
            JobFactory = jobFactory;
        }

        public List<IBot> Bots { get; }
        public JobFactory JobFactory { get; }

        public void SimulateTwoBots(IBot bot1, IBot bot2)
        {
            Character bot1Character = new Character(bot1.ChooseName(),
                                                    new Health(200, 200),
                                                    new Mana(100, 100),
                                                    new Inventory())
            {
                ActualJob = bot1.ChooseJob(JobFactory) as JobBase
            };

            Character bot2Character = new Character(bot2.ChooseName(),
                                        new Health(200, 200),
                                        new Mana(100, 100),
                                        new Inventory())
            {
                ActualJob = bot2.ChooseJob(JobFactory) as JobBase
            };

            Game game = new Game(bot1Character, bot2Character);
            game.GameState = GameState.Running;

            while (game.GameState != GameState.Finished)
            {
                bot1.DoTurn(game);
                Console.WriteLine(bot2Character.Name + " " + bot2Character.Health.CurrentHealth);

                if (game.GameState != GameState.Finished)
                {
                    game.CyclePlayers();
                    bot2.DoTurn(game);
                    game.CyclePlayers();
                }
            }

            if (bot1Character.Health.CurrentHealth == 0)
            {
                Console.WriteLine(bot2Character.Name + " has won!");
            }
            else
            {
                Console.WriteLine(bot1Character.Name + " has won!");
            }
        }
    }
}
