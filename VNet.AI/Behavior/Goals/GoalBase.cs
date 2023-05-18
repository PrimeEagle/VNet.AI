using VNet.AI.Behavior.Objectives;

namespace VNet.AI.Behavior.Goals
{
    public abstract class GoalBase : IGoal
    {
        public ICollection<IObjective> Objectives { get; set; }

        public GoalBase()
        {
            Objectives = new HashSet<IObjective>();
        }
    }
}
