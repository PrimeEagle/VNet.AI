using VNet.AI.Behavior.Objectives;

namespace VNet.AI.Behavior.Goals
{
    public interface IGoal
    {
        public ICollection<IObjective> Objectives { get; set; }
    }
}