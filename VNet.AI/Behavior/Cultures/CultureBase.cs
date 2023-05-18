using VNet.AI.Behavior.Agents;

namespace VNet.AI.Behavior.Cultures
{
    public class CultureBase : ICulture
    {
        public IAgent Agent { get; set; }
        public IList<ICulturalNorm> Norms { get; set; }
    }
}