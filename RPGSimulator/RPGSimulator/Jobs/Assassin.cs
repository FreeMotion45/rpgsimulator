using RPGSimulator.Common.Character.Jobs;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs
{
    class Assassin : JobBase
    {
        private Random _random;
        private double _healthStolen;
        private int _percentageToSteal;
        private int _defensePenetrationPercentage;

        public Assassin(SkillBase skill) : base(skill, 5, 11, JobType.Assassin)
        {
            _random = new Random();
        }

        public override void AddBonusAttributes(Character self)
        {
            _percentageToSteal = 4;
            _defensePenetrationPercentage = 10;
            _healthStolen = 0;
        }

        public override void Attack(Character self, Character target)
        {
            int damage = CalculateAttackDamage();

            damage = (int)(damage -
                (self.Job.Defense * 1.0 - self.Job.Defense * _defensePenetrationPercentage * 1.0));

            _healthStolen += (damage * _percentageToSteal * 1.0D) / 100;

            target.ActualHealth.DealDamage(damage);
        }

        public override void UseSpecialAbility(Character self, Character target)
        {
            ActualSpecialAbility.UseSkill(self, target);
        }

        private int CalculateAttackDamage()
        {
            return _random.Next(MinimumDamage, MaximumDamage);
        }
    }
}
