using RPGSimulator.Core.Modules;
using RPGSimulatorCommon.Contracts;

namespace RPGSimulator.Core.Abstractions
{
    public interface IJobActions : IJob
    {
        void Attack(Character target);
        void UseSpecialAbility(Character target);
        void AddBonusAttributes(Character self);        
    }
}
