using System.Collections.Concurrent;
using VNet.AI.Behavior.Aspects;
using VNet.AI.Behavior.Cultures;
using VNet.AI.Behavior.Minds;
using VNet.AI.Behavior.Relationships;

namespace VNet.AI.Behavior.Agents
{
    public abstract class AgentBase : IAgent
    {
        public IAspect Aspect { get; init; }
        public IMind Mind { get; init; }
        public IBiographicalInfo BiographicalInfo { get; init; }
        public ICulture Culture { get; init; }
        public IDictionary<IAgent, List<IRelationship>> Relationships { get; init; }

        #region Events

        public event EventHandler PositionChanged;

        protected void OnPositionChanged(PropertyEventArgs e)
        {
            PositionChanged?.Invoke(this, e);
        }

        #endregion Events

        #region Constructors

        public AgentBase(IAspect aspect, IMind mind, IBiographicalInfo biographicalInfo, ICulture culture)
        {
            Aspect = aspect;
            Aspect.Agent = this;

            Mind = mind;
            Mind.Agent = this;

            BiographicalInfo = biographicalInfo;
            BiographicalInfo.Agent = this;

            Culture = culture;
            Culture.Agent = this;

            Relationships = new ConcurrentDictionary<IAgent, List<IRelationship>>();
        }

        #endregion Constructors
    }
}