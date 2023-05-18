using VNet.AI.Behavior.Agents;

namespace VNet.AI.Behavior.Senses
{
    public class SightSense : SenseBase
    {
        public SightSense(string name, IAgent agent) : base(name, agent)
        {
            //this.RequiresLOS = true;
            //this.DifferentialThreshold = 0.1f;
            //this.MinimumThreshold = 10;
            //this.MinimumDistance = 20;
            //this.IsActive = true;
            //this.IsContinuous = true;
            //this.CanDetect.Add(typeof(IVisible));
        }

        //public override void OnSensed(EventArgs e)
        //{
        //    base.OnSensed(e);
        //    OnSee(e);
        //}

        //public virtual void OnSee(EventArgs e)
        //{
        //    EventHandler<EventArgs> handler = See;
        //    if (handler != null)
        //    {
        //        handler(this, e);
        //    }
        //}

        //public event EventHandler<EventArgs> See;
    }
}
