using VNet.DataStructures.Map;

namespace VNet.AI.Behavior
{
    public static class BehaviorManager
    {
        public static float SimulationLevel { get; set; }
        public static TypeMultimap TriggerStimuli { get; set; } = new TypeMultimap();



        public static void Initialize(float simulationLevel, Func<float, TypeMultimap> configureMappingFunction)
        {
            SimulationLevel = simulationLevel;
            TriggerStimuli = new TypeMultimap();

            TriggerStimuli = configureMappingFunction(SimulationLevel);
        }
    }
}