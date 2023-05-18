using System.Collections.Concurrent;
using VNet.AI.Behavior.Agents;
using VNet.AI.Behavior.SensoryComponents;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.Senses
{
    public abstract class SenseBase : ISense
    {
        public bool Enabled { get; set; }
        public IAgent Agent { get; init; }
        public ConcurrentQueue<IStimulus> DetectedStimuli { get; set; }
        public ConcurrentQueue<IStimulus> SensedStimuli { get; set; }
        public ICollection<ISensoryComponent> Components { get; set; }



        public SenseBase(string name, IAgent agent)
        {
            Agent = agent;
            DetectedStimuli = new ConcurrentQueue<IStimulus>();
            SensedStimuli = new ConcurrentQueue<IStimulus>();
            Components = new List<ISensoryComponent>();
            AddComponents();
            ConfigureComponents();
        }

        public virtual void AddComponents()
        {
            Components.Clear();
            Components.Add(new SensoryCategoryComponent(this));
            Components.Add(new SensoryAdaptationComponent(this));
            Components.Add(new SensoryRangeComponent(this));
            Components.Add(new SensoryThresholdComponent(this));
            Components.Add(new SensoryLineOfSightComponent(this));
            Components.Add(new SensoryFieldOfViewComponent(this));
        }

        public virtual void ConfigureComponents()
        {

        }

        private float AmountDetected(IStimulus stimulus)
        {
            float result = 0f;

            if (Enabled)
            {
                result = stimulus.Amount;

                foreach (var component in Components)
                {
                    // result = component.AmountDetected(result);
                }
            }

            return result;
        }

        protected void FilterDetectedStimuli()
        {
            while (DetectedStimuli.Count > 0)
            {
                IStimulus stimulus;

                if (DetectedStimuli.TryDequeue(out stimulus))
                {
                    bool sensing = true;

                    if (Enabled)
                    {
                        foreach (var component in Components)
                        {
                            if (!component.IsSensing(stimulus))
                            {
                                sensing = false;
                                break;
                            }
                        }
                    }

                    if (sensing)
                    {
                        SensedStimuli.Enqueue(stimulus);
                    }
                }
            }
        }

        protected void ProcessSensedStimuli()
        {
            while (SensedStimuli.Count > 0)
            {
                IStimulus stimulus;

                if (SensedStimuli.TryDequeue(out stimulus))
                {
                    //...
                }
            }
        }

        public bool IsSensing(IStimulus stimulus)
        {
            return Enabled && Components.Where(c => c.Enabled).All(c => c.IsSensing(stimulus));
        }

        public bool IsDetecting()
        {
            return DetectedStimuli.Count > 0;
        }
    }
}