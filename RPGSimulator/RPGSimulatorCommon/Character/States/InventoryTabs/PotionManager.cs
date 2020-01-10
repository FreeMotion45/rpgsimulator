using RPGSimulatorCommon.Contracts;
using RPGSimulatorCommon.Potions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character.States.InventoryTabs
{
    class PotionManager
    {
        private readonly Inventory _inventory;

        public PotionManager(Inventory inventory)
        {
            _inventory = inventory;
        }

        public IPotion PopPotion(PotionType potionType)
        {
            
        }
    }
}
