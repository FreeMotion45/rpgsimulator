using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Common.Character;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs;

namespace RPGSimulator.Core.Modules.Jobs
{
    public class Warrior : IJobExtended
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

        public JobType JobType => JobType.Warrior;

        public void AddBonusAttributes(Character self)
        {
            self.ActualHealth.MaxHealth = (int)(self.Health.MaxHealth * 1.2);
            self.ActualHealth.CurrentHealth = self.Health.MaxHealth;
        }

        public void Attack(Character target)
        {
            target.ActualHealth.CurrentHealth -= CalculateAttackDamage();
        }

        public void UseSpecialAbility(Character target)
        {
            target.ActualHealth.CurrentHealth -= CalculateSpecialAbilityDamage();
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
