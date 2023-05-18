using System.Numerics;
using VNet.AI.Behavior.Agents;

namespace VNet.AI.Behavior.Aspects
{
    public interface IAspect
    {
        public IAgent Agent { get; set; }
        public Vector3 Position { get; set; }


        public void Trigger();
    }
}