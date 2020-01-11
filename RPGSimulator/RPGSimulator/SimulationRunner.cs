using RPGSimulator.Bots;
using RPGSimulator.Common.Contracts;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulator.Core.Modules.States;
using RPGSimulator.Jobs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator
{
    class SimulationRunner
    {
        private List<Bot> _simulatedBots;

        public SimulationRunner(List<IBot> bots, JobFactory jobFactory)
        {
            Bots = bots;
            JobFactory = jobFactory;
            _simulatedBots = new List<Bot>();
            CreateBotCharacters();
        }

        public List<IBot> Bots { get; }
        public JobFactory JobFactory { get; }

        public void RunAllSimulations()
        {
            List<Task> runningSimulations = new List<Task>();

            foreach (var botSelf in _simulatedBots)
            {
                foreach (var botEnemy in _simulatedBots)
                {
                    // Obviously if 1 didnt run a simulation against another bot, then the other neither run against him.
                    // Thats why its ok only to check if botSelf was against botEnemy.
                    if (botSelf != botEnemy && !botSelf.EnemyHistory.Contains(botEnemy))
                    {
                        botSelf.EnemyHistory.Add(botEnemy);
                        botEnemy.EnemyHistory.Add(botSelf);

                        List<Bot> participatingBots = new List<Bot>()
                        {
                            botSelf,
                            botEnemy
                        };

                        runningSimulations.Add(
                            Task.Run(() => RunSimulation(participatingBots))
                            );
                    }
                }
            }

            Task.WaitAll(runningSimulations.ToArray());
        }

        private void RunSimulation(List<Bot> participatingBots)
        {
            Simulation simulation = new Simulation(participatingBots);
            simulation.Run();
        }

        private void CreateBotCharacters()
        {
            foreach (var bot in Bots)
            {
                Character character = new Character(bot.ChooseName(),
                                                    new Health(200, 200),
                                                    new Mana(100, 100),
                                                    bot.ChooseJob(JobFactory),
                                                    new Inventory());

                Bot characterBot = new Bot(character, bot);
                _simulatedBots.Add(characterBot);
            }
        }
    }
}
