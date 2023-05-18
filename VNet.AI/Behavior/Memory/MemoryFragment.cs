using VNet.AI.Behavior.Agents;
using VNet.AI.Behavior.Aspects;
using VNet.AI.Behavior.Emotions;
using VNet.AI.Behavior.Goals;

namespace VNet.AI.Behavior.Memory
{
    public class MemoryFragment : IMemoryFragment
    {
        public Guid Id { get; init; }
        public bool Enabled { get; set; }
        public bool Emotional { get; set; }
        public bool Episodic { get; set; }
        public bool Autobiographical { get; set; }
        public bool Semantic { get; set; }
        public bool Procedural { get; set; }
        public float Reliability { get; set; }
        public float Recall { get; set; }
        public DateTime? SourceTime { get; set; }
        public string SourceLocation { get; set; }
        public int WitnessDegreesOfSeparation { get; set; }
        public ICollection<IAspect> AssociatedAspects { get; set; }
        public ICollection<IAgent> AssociatedAgents { get; set; }
        public ICollection<Guid> AssociatedMemoryFragments { get; set; }
        public ICollection<IGoal> AssociatedGoals { get; set; }
        public ICollection<IEmotion> AssociatedEmotions { get; set; }


        public MemoryFragment()
        {
            Id = Guid.NewGuid();
            AssociatedAspects = new List<IAspect>();
            AssociatedAgents = new List<IAgent>();
            AssociatedMemoryFragments = new List<Guid>();
            AssociatedGoals = new List<IGoal>();
            AssociatedEmotions = new List<IEmotion>();
            SourceLocation = string.Empty;
            Enabled = true;
        }
    }
}