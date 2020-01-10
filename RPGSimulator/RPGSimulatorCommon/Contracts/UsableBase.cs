using RPGSimulatorCommon.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Contracts
{
    abstract class UsableBase
    {
        CharacterState Owner { get; }

        public void Use()
        {
            Owner.Inventory.Remove(this);
            EffectOwner();
        }

        protected abstract void EffectOwner();
    }
}
