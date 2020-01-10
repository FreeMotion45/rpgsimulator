using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulatorCommon.Character.Jobs
{
    class Warrior : IJob
    {
        public readonly int _minimumDamage;
        public readonly int _maximumDamage;
        public readonly Random random;

        public Warrior()
        {
            _minimumDamage = 9;
            _maximumDamage = 15;
            random = new Random();
        }

        public void AddBonusAttributes(ICharacter self)
        {
            throw new NotImplementedException();
        }

        public void Attack(ICharacter target)
        {
            target.Health.CurrentHealth -= CalculateAttackDamage(); 
        }

        public void UseSpecialAbility(ICharacter target)
        {
            throw new NotImplementedException();
        }

        private int CalculateAttackDamage()
        {
            return random.Next(_minimumDamage, _maximumDamage);
        }
    }
}
