using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.SensoryComponents
{
    public class SensoryLineOfSightComponent : SensoryComponent
    {
        public float _normalAttenuation;
        public float _transparentAttenuation;


        public float NormalAttenuation
        {
            get
            {
                return _normalAttenuation;
            }
            set
            {
                if (value >= 0f && value <= 1f)
                {
                    _normalAttenuation = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Normal Attenuation value must be between 0 and 1, inclusive.");
                }
            }
        }

        public float TransparentAttenuation
        {
            get
            {
                return _transparentAttenuation;
            }
            set
            {
                if (value >= 0f && value <= 1f)
                {
                    _transparentAttenuation = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Transparent Attenuation value must be between 0 and 1, inclusive.");
                }
            }
        }

        public SensoryLineOfSightComponent(ISense sense) : base(sense)
        {
            Enabled = false;
        }

        private float TotalAttenuation(IStimulus stimulus)
        {
            return Math.Clamp(stimulus.NumberOfNormalLosBlockers * NormalAttenuation + stimulus.NumberOfTransparentLosBlockers * TransparentAttenuation, 0, 1);
        }

        public float AmountDetected(IStimulus stimulus)
        {
            float result = stimulus.Amount;

            if (Enabled && stimulus.NumberOfNormalLosBlockers + stimulus.NumberOfTransparentLosBlockers > 0)
            {
                result = result * (1f - TotalAttenuation(stimulus));
            }

            return result;
        }
    }
}