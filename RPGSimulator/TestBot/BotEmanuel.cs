using RPGSimulator.Common.Contracts;
using RPGSimulatorCommon.Character.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBot
{
    public class BotEmanuel : IBot
    {
        public IJob ChooseJob(IJobFactory jobFactory)
        {
            return jobFactory.CreateJob(JobType.Mage);
        }

        public void DoTurn(IGameController game)
        {
            Console.WriteLine("Emanuel is pro!");
        }
    }
}
