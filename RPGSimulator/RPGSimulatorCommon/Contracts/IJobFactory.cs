using RPGSimulatorCommon.Character;

namespace RPGSimulatorCommon.Contracts
{
    public interface IJobFactory
    {
        IJob CreateJob(JobType jobType);
    }
}
