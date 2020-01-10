using RPGSimulatorCommon.Potions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Contracts
{
    interface IPotion : IUsable
    {
        PotionType PotionType { get; }
    }
}
