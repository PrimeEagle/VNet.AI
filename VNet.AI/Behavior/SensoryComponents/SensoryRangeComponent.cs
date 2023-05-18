using System.Numerics;
using VNet.AI.Behavior.Aspects;
using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.SensoryComponents
{
    public class SensoryRangeComponent : SensoryComponent
    {
        private float? _minimumDistance;
        private float? _maximumDistance;
        private float _differentialDistance;
        private float _lastDistance;
        private float _lastDistanceSquared;
        private float _minimumDistanceSquared;
        private float _maximumDistanceSquared;
        private float _differentialDistanceSquared;

        public float? MinimumDistance
        {
            get
            {
                return _minimumDistance;
            }
            set
            {
                _minimumDistance = value;
                _minimumDistanceSquared = _minimumDistance.HasValue ? (float)Math.Pow(_minimumDistance.Value, 2) : float.MinValue;
            }
        }
        public float? MaximumDistance
        {
            get
            {
                return _maximumDistance;
            }
            set
            {
                _maximumDistance = value;
                _maximumDistanceSquared = _maximumDistance.HasValue ? (float)Math.Pow(_maximumDistance.Value, 2) : float.MaxValue;
            }
        }
        public float DifferentialDistance
        {
            get
            {
                return _differentialDistance;
            }
            set
            {
                _differentialDistance = value;
                _differentialDistanceSquared = (float)Math.Pow(_differentialDistance, 2);
            }
        }
        public Tuple<float, float> Falloff { get; set; }



        public SensoryRangeComponent(ISense sense) : base(sense)
        {
            _minimumDistance = float.MinValue;
            _maximumDistance = float.MaxValue;
            _differentialDistance = 1f;
            _differentialDistanceSquared = 0f;
            _lastDistance = 0f;
            _lastDistanceSquared = 0f;
            Falloff = new Tuple<float, float>(0f, 1f);
            Enabled = false;
        }

        private float DistanceSquaredTo(Vector3 position, IAspect target)
        {
            return DistanceSquaredTo(position, target.Position);
        }

        private float DistanceSquaredTo(Vector3 position, Vector3 targetPosition)
        {
            return (targetPosition - position).LengthSquared();
        }

        internal bool IsInRange(Vector3 position, IAspect target)
        {
            float distanceToTargetSquared = DistanceSquaredTo(position, target);

            return _minimumDistanceSquared <= distanceToTargetSquared && distanceToTargetSquared <= _maximumDistanceSquared;
        }

        public float AmountDetected(IStimulus stimulus)
        {
            float result = stimulus.Amount;
            float attAmount = Falloff.Item1;
            float attDistance = Falloff.Item2;

            if (Enabled & attAmount > 0f)
            {
                float distanceToTarget = (float)Math.Sqrt(DistanceSquaredTo(Sense.Agent.Aspect.Position, stimulus.Source.Position));
                float numAttenuations = distanceToTarget / attDistance;
                float amountOfAttenuation = Math.Clamp(numAttenuations * attAmount, 0, 1);

                result = result * (1 - amountOfAttenuation);
            }

            return result;
        }
    }
}