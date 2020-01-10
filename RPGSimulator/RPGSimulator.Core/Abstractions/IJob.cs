using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character.Jobs
{
    interface IJob
    {
        void Attack(ICharacter target);
        void UseSpecialAbility(ICharacter target);
        void AddBonusAttributes(ICharacter self);        
    }
}
