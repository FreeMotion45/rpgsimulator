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

        // This function should be called when initializing the bot's character
        public void AddBonusAttributes(ICharacter self)
        {
            self.Health.MaxHealth = (int) (self.Health.MaxHealth * 1.2);
            self.Health.CurrentHealth = self.Health.MaxHealth;
        }

        public void Attack(ICharacter target)
        {
            target.Health.CurrentHealth -= CalculateAttackDamage(); 
        }

        public void UseSpecialAbility(ICharacter target)
        {
            target.Health.CurrentHealth -= CalculateSpecialAbilityDamage();
        }

        private int CalculateAttackDamage()
        {
            return random.Next(_minimumDamage, _maximumDamage);
        }

        private int CalculateSpecialAbilityDamage()
        {
            return random.Next(_minimumDamage * 2, _maximumDamage * 2);
        }
    }
}
