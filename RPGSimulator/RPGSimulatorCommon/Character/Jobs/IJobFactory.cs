using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character.Jobs
{
    public interface IJobFactory
    {
        IJob CreateJob(JobType jobType);
    }
}
