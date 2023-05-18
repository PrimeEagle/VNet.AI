using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.SensoryComponents
{
    public abstract class SensoryComponent : ISensoryComponent
    {
        public bool Enabled { get; set; }
        public ISense Sense { get; set; }

        public SensoryComponent(ISense sense)
        {
            Sense = sense;
        }

        public bool IsSensing(IStimulus stimulus)
        {
            throw new NotImplementedException();
        }
    }
}