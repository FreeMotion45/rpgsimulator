using RPGSimulator.Common.Contracts;
using RPGSimulatorCommon.Character.Jobs;
using System.Linq;

namespace TestBot
{
    public class BotSean : IBot
    {
        public IJob ChooseJob(IJobFactory jobFactory)
        {
            return jobFactory.CreateJob(JobType.Warrior);
        }

        public string ChooseName()
        {
            return "Sean";
        }

        public void DoTurn(IGameController game)
        {
            System.Console.WriteLine("I skipped my turn!");
        }
    }
}
