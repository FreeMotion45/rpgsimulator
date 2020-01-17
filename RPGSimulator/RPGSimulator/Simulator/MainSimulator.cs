using RPGSimulator.Bots;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Modules;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Jobs;
using RPGSimulator.Simulator.SimulatorRunners;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Simulator
{
    class MainSimulator
    {
        private List<Bot> _assignedBots;

        public MainSimulator(List<IBot> bots, ISimulationRunner simulationRunner, JobFactory jobFactory)
        {
            Bots = bots;
            SimulationRunner = simulationRunner;
            _assignedBots = new List<Bot>();
            JobFactory = jobFactory;
            CreateBotCharacters(bots);
        }

        public List<IBot> Bots { get; }
        public JobFactory JobFactory { get; }
        public ISimulationRunner SimulationRunner { get; }

        public void Simulate()
        {
            SimulationRunner.RunSimulations(_assignedBots);
        }

        private void CreateBotCharacters(List<IBot> bots)
        {
            foreach (var bot in bots)
            {
                Character character = new Character(bot.ChooseName(),
                                                    new Health(200, 200),
                                                    new Mana(100, 100),
                                                    bot.ChooseJob(JobFactory),
                                                    new Inventory());

                Bot characterBot = new Bot(character, bot);
                _assignedBots.Add(characterBot);
            }
        }
    }
}
