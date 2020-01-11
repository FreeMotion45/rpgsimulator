using RPGSimulator.Bots;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Simulator.SimulatorRunners
{
    interface ISimulationRunner
    {
        void RunSimulations(List<Bot> botsToSimulate);
    }
}
