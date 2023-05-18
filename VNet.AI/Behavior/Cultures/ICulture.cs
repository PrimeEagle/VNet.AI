using VNet.AI.Behavior.Agents;

namespace VNet.AI.Behavior.Cultures
{
    public interface ICulture
    {
        public IAgent Agent { get; set; }
    }
}