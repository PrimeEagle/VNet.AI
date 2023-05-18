using VNet.AI.Behavior.Senses;

namespace VNet.AI.Behavior.SensoryComponents
{
    public class SensoryCategoryComponent : SensoryComponent
    {
        public SourceCategory SourceCategory { get; init; }
        public ModalityType ModalityType { get; init; }
        public ModalitySubtype ModalitySubtype { get; init; }


        public SensoryCategoryComponent(ISense sense) : base(sense)
        {
            Enabled = false;
        }
    }
}