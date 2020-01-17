using RPGSimulator.Core.Modules.Jobs;
using RPGSimulator.Jobs.Skills;
using RPGSimulatorCommon.Character.Jobs;
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
                JobType.Warrior => new Warrior(new FullStrengthAttack("Full strength attack", "Attack with double the normal power")),
                JobType.Mage => new Mage(new ManaReduction("Mana reduction", "Removes 10% of your enemie's current HP and 50% of his current MP")),
                _ => null,
            };
        }
    }
}
