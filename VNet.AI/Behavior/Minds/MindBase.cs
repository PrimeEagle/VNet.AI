using System.Collections.Concurrent;
using VNet.AI.Behavior.Agents;
using VNet.AI.Behavior.Emotions;
using VNet.AI.Behavior.Memory;
using VNet.AI.Behavior.Moods;
using VNet.AI.Behavior.Personalities;
using VNet.AI.Behavior.Senses;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Behavior.Minds
{
    public abstract class MindBase : IMind
    {
        public bool Enabled { get; set; }
        public IAgent Agent { get; set; }
        public ConcurrentQueue<IStimulus> DetectedStimuli { get; set; }
        public HashSet<ISense> Senses { get; set; }
        public IMemory Memory { get; set; }
        public IPersonality Personality { get; set; }
        public Queue<IMood> Moods { get; set; }
        public Queue<IEmotion> Emotions { get; set; }


        public MindBase(IPersonality personality, IMemory memory)
        {
            Enabled = true;
            Senses = new HashSet<ISense>();
            Memory = memory;
            DetectedStimuli = new ConcurrentQueue<IStimulus>();

            Personality = personality;
            Moods = new Queue<IMood>();
            Emotions = new Queue<IEmotion>();
        }

        public void Sense()
        {

        }

        public void Think()
        {

        }

        public void Act()
        {

        }

        public void Reflect()
        {

        }

        public void Reinforce()
        {

        }

        public void Reintegrate()
        {

        }
        private IEnumerable<ISense> GetSenses()
        {
            return Senses;
        }

        //private IEnumerable<ISense> GetSenses(SenseTriggerType triggerType)
        //{
        //    return Senses.Where(s => s.Triggers.Any(t => t.TriggerType == triggerType));
        //}

        //private IEnumerable<ISense> GetSenses(SourceCategory sourceCategory)
        //{
        //    return Senses.Where(s => s.SourceCategory == sourceCategory);
        //}

        //private IEnumerable<ISense> GetSenses(ModalityType modalityType)
        //{
        //    return Senses.Where(s => s.ModalityType == modalityType);
        //}

        //private IEnumerable<ISense> GetSenses(ModalitySubtype modalitySubtype)
        //{
        //    return Senses.Where(s => s.ModalitySubtype == modalitySubtype);
        //}
    }
}