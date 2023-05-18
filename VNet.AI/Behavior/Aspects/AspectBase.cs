using System.Numerics;
using VNet.AI.Behavior.Agents;

namespace VNet.AI.Behavior.Aspects
{
    public abstract class AspectBase : IAspect
    {
        public IAgent Agent { get; set; }
        public Vector3 Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void Trigger()
        {
            throw new NotImplementedException();
        }
    }
}
