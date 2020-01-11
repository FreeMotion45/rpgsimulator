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
    class SimulatorRunner
    {
        public IBot Bots { get; }
        public JobFactory JobFactory { get; }

        public void SimulateTwoBots(IBot bot1, IBot bot2)
        {
            Character bot1Character = new Character(new Health(200, 200),
                                                    new Mana(100, 100),
                                                    new Inventory())
            {
                ActualJob = bot1.ChooseJob(JobFactory) as JobBase
            };

            Character bot2Character = new Character(new Health(200, 200),
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
                bot2.DoTurn(game);
            }
        }
    }
}
