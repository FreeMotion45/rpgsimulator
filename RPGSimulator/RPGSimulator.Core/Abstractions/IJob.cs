﻿using RPGSimulator.Core.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSimulator.Core.Abstractions
{
    public interface IJob
    {
        void Attack(Character target);
        void UseSpecialAbility(Character target);
        void AddBonusAttributes(Character self);
    }
}
