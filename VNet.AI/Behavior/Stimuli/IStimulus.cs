using VNet.AI.Behavior.Aspects;

namespace VNet.AI.Behavior.Stimuli
{
    public interface IStimulus
    {
        public IAspect Source { get; init; }
        public SourceCategory SourceCategory { get; init; }
        public ModalityType ModalityType { get; init; }
        public ModalitySubtype ModalitySubtype { get; init; }
        public float Amount { get; init; }
        public float Range { get; init; }
        public int NumberOfNormalLosBlockers { get; init; }
        public int NumberOfTransparentLosBlockers { get; init; }
    }
}