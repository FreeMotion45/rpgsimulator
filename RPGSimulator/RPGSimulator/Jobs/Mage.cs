﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGSimulator.Core.Abstractions;
using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Character.Jobs;

namespace RPGSimulator.Core.Modules.Jobs
{
    public class Mage : JobBase
    {
        public readonly Random _random;

        public Mage(SkillBase skill) : base(skill, 5, 11, JobType.Mage)
        {
            _random = new Random();
        }

        public override void AddBonusAttributes(Character self)
        {
            self.ActualMana.IncreaseMaxMana((int)(self.GetMana().MaxMana * 1.3));
            self.ActualMana.IncreaseMana(self.ActualMana.MaxMana);           
        }

        public override void Attack(Character self, Character target)
        {
            target.ActualHealth.DecreaseHealth(CalculateAttackDamage());
        }

        public override void UseSpecialAbility(Character self, Character target)
        {
            Skill.UseSkill(self, target);
        }

        private int CalculateAttackDamage()
        {
            return _random.Next(MinimumDamage, MaximumDamage);
        }
    }
}
