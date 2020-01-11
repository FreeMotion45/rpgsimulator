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

        public void SimulateTwoBots(IBot Bot1, IBot Bot2)
        {
            Simulation simulation = new Simulation(Bot1, Bot2, JobFactory);
            simulation.Run();
        }
    }
}
