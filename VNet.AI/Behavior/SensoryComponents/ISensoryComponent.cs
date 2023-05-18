using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.SensoryComponents
{
    public interface ISensoryComponent
    {
        public bool Enabled { get; }
        public ISense Sense { get; }

        public bool IsSensing(IStimulus stimulus);
    }
}
