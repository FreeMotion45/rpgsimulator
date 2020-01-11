
using RPGSimulatorCommon.Character.Jobs;

namespace RPGSimulator.Common.Contracts
{
    public interface IBot
    {
        void DoTurn(IGameController game);
        void ChooseJob(IJobFactory jobFactory);
    }
}
