using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.SensoryComponents
{
    public class SensoryAdaptationComponent : SensoryComponent
    {
        private float _attenuation;


        public int NumberOfTotalEvents { get; set; }
        public int NumberOfQualifyingEvents { get; set; }
        public int MinimumEvents { get; set; }
        public float MinimumThreshold { get; set; }
        public float Attenuation
        {
            get
            {
                return _attenuation;
            }
            set
            {
                if (value >= 0f && value <= 1f)
                {
                    _attenuation = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Attenuation value must be between 0 and 1, inclusive.");
                }
            }
        }
        public bool IsAdapted
        {
            get
            {
                return Enabled && NumberOfQualifyingEvents >= MinimumEvents && MinimumThreshold < float.MaxValue;
            }
        }

        public SensoryAdaptationComponent(ISense sense) : base(sense)
        {
            MinimumThreshold = float.MaxValue;
        }

        public float AmountDetected(IStimulus stimulus)
        {
            return AmountDetected(stimulus.Amount);
        }

        public float AmountDetected(float amount)
        {
            float result = amount;

            if (IsAdapted)
            {
                result = result * (1f - Attenuation);
            }

            return result;
        }

        public void Update(float amount)
        {
            if (Enabled)
            {
                NumberOfTotalEvents++;

                if (amount >= MinimumThreshold)
                {
                    NumberOfQualifyingEvents++;
                }
            }
        }

        public void Reset()
        {
            NumberOfTotalEvents = 0;
            NumberOfQualifyingEvents = 0;
        }
    }
}