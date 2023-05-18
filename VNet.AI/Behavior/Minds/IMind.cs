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
    public interface IMind
    {
        public IAgent Agent { get; set; }
        public HashSet<ISense> Senses { get; set; }
        public IMemory Memory { get; set; }
        public ConcurrentQueue<IStimulus> DetectedStimuli { get; set; }
        public IPersonality Personality { get; set; }
        public Queue<IMood> Moods { get; set; }
        public Queue<IEmotion> Emotions { get; set; }


        public void Sense();
        public void Think();
        public void Act();
    }
}