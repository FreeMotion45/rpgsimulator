using RPGSimulator.Core.Modules.Jobs;
using RPGSimulatorCommon.Character.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs
{
    class JobFactory : IJobFactory
    {
        public IJob CreateJob(JobType jobType)
        {
            switch (jobType)
            {
                case JobType.Warrior:
                    return new Warrior();
                case JobType.Mage:
                    return new Mage();
                default:
                    return null;
            }
        }
    }
}
