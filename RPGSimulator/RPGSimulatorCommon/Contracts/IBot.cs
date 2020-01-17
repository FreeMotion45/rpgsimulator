
using RPGSimulator.Common.Character.Jobs;

namespace RPGSimulator.Common.Contracts
{
    public interface IBot
    {
        void DoTurn(IGameController game);
        IJob ChooseJob(IJobFactory jobFactory);
        string ChooseName();
    }
}
