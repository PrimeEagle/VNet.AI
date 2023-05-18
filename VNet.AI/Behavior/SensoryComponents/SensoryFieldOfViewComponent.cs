using VNet.AI.Behavior.Senses;

namespace VNet.AI.Behavior.SensoryComponents
{
    public class SensoryFieldOfViewComponent : SensoryComponent
    {
        public float From { get; set; }
        public float To { get; set; }
        public float Range
        {
            get
            {
                return To - From;
            }
        }

        public SensoryFieldOfViewComponent(ISense sense) : base(sense)
        {
            Enabled = true;
            From = -45f;
            To = 45f;
        }
    }
}