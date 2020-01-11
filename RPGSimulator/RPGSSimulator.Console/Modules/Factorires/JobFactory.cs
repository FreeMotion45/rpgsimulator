using RPGSimulatorCommon.Character;
using RPGSimulatorCommon.Contracts;
using RPGSSimulator.Console.Modules.Jobs;

namespace RPGSSimulator.Console.Modules.Factorires
{
    public class JobFactory : IJobFactory
    {
        public JobFactory(ICharacter self)
        {

        }

        public IJob CreateJob(JobType jobType)
        {
            switch (jobType)
            {
                case JobType.Mage:
                    return new Mage();
                default:
                    return null;
            }
        }
    }
}
