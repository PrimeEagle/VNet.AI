using VNet.AI.Behavior.Aspects;
using VNet.AI.Behavior.Cultures;
using VNet.AI.Behavior.Minds;
using VNet.AI.Behavior.Relationships;

namespace VNet.AI.Behavior.Agents
{
    public interface IAgent
    {
        public IAspect Aspect { get; init; }
        public IMind Mind { get; init; }
        public IBiographicalInfo BiographicalInfo { get; init; }
        public ICulture Culture { get; init; }
        public IDictionary<IAgent, List<IRelationship>> Relationships { get; init; }
    }
}