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

        public void DoTurn(IGameController game)
        {
            System.Console.WriteLine(game.Self.Job);
            foreach (var item in game.Self.Inventory.GetPotions())
            {
                System.Console.WriteLine("Potion name: {0}, Potion type: {1}", item.Name, item.PotionType);
            }
        }
    }
}
