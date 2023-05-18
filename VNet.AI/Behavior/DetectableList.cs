using VNet.AI.Behavior.Aspects;

namespace VNet.AI.Behavior
{
    public class DetectableList : List<IAspect>
    {
        public new void Add(IAspect t)
        {
            if (t is null)
            {
                throw new NullReferenceException("Cannot add a null");
            }

            if (t is not IAspect)
            {
                throw new InvalidOperationException("Type does not implement IAspect.");
            }

            base.Add(t);
        }
    }
}