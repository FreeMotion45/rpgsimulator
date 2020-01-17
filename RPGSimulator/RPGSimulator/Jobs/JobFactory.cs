using RPGSimulator.Core.Modules.Jobs;
using RPGSimulator.Jobs.Skills;
using RPGSimulator.Common.Character.Jobs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPGSimulator.Jobs
{
    class JobFactory : IJobFactory
    {
        public IJob CreateJob(JobType jobType)
        {
            return jobType switch
            {
            JobType.Warrior => new Warrior(new FullStrengthAttack("Attack with double the normal power")),
            JobType.Mage => new Mage(new ManaReduction("Removes 10% of your enemie's current HP and 50% of his current MP")),
            JobType.Assassin => new Assassin(new HealthSteal("Deal 250% of your normal damage with 100% defense penetration." +
            "Out of your total damage dealt, 50% will be returned to your health.")),
                _ => null,
            };
        }
    }
}
