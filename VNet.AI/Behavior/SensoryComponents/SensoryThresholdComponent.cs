using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.SensoryComponents
{
    public class SensoryThresholdComponent : SensoryComponent
    {
        private float _lastThreshold;


        public float MinimumThreshold { get; set; }
        public float DifferentialThreshold { get; set; }

        public SensoryThresholdComponent(ISense sense) : base(sense)
        {
        }

        internal bool IsInRange(IStimulus stimulus)
        {
            return MinimumThreshold <= stimulus.Amount;
        }

        public float AmountDetected(IStimulus stimulus)
        {
            return AmountDetected(stimulus.Amount);
        }

        public float AmountDetected(float amount)
        {
            return amount;
        }
    }
}