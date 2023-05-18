using System.Collections.Concurrent;
using VNet.AI.Behavior.Agents;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.Senses
{
    public interface ISense
    {
        public IAgent Agent { get; init; }
        public ConcurrentQueue<IStimulus> DetectedStimuli { get; set; }
        public ConcurrentQueue<IStimulus> SensedStimuli { get; set; }



        public bool IsDetecting();
        public bool IsSensing(IStimulus stimulus);
        public void AddComponents();
        public void ConfigureComponents();
    }
}