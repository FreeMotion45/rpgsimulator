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

namespace RPGSimulator.Simulator.SimulatorRunners
{
    class FullSimulationRunner : ISimulationRunner
    {
        // This runner simulates all possible matches (while considering match history to avoid two bots fighting more than once).

        public void RunSimulations(List<Bot> botsToSimulate)
        {
            List<Task> runningSimulations = new List<Task>();

            foreach (var botSelf in botsToSimulate)
            {
                foreach (var botEnemy in botsToSimulate)
                {
                    // Obviously if 1 didnt run a simulation against another bot, then the other neither run against him.
                    // Thats why its ok only to check if botSelf was against botEnemy.
                    if (botSelf != botEnemy && !botSelf.EnemyHistory.Contains(botEnemy))
                    {
                        botSelf.EnemyHistory.Add(botEnemy);
                        botEnemy.EnemyHistory.Add(botSelf);

                        List<Bot> botsParticipatingInGame = new List<Bot>()
                        {
                            botSelf,
                            botEnemy
                        };

                        runningSimulations.Add(
                            Task.Run(() => RunSimulation(botsParticipatingInGame))
                            );
                    }
                }
            }

            Task.WaitAll(runningSimulations.ToArray());
        }

        private void RunSimulation(List<Bot> botsParticipatingInGame)
        {
            Simulation simulation = new Simulation(botsParticipatingInGame);
            simulation.Run();
        }
    }
}
