using RPGSimulatorCommon.Contracts;

namespace TestBot
{
    public class BotSean : IBot
    {
        public void DoTurn(IGameController controller)
        {
            foreach (var item in controller.Self.Inventory.Items)
            {
                System.Console.WriteLine(item.Name);
            }
        }
    }
}
