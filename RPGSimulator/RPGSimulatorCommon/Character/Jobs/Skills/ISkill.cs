﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Common.Character.Jobs.Skills
{
    public interface ISkill
    {
        SkillName Name { get; }
        string Description { get; }
    }
}
