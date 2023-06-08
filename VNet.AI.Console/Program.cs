using System.Numerics;
using VNet.System;
using VNet.AI.Behavior;
using VNet.DataStructures.Map;
using VNet.AI.Behavior.Triggers;
using VNet.AI.Behavior.Stimuli;

namespace VNet.AI.Terminal
{
    internal class Program
    {
        public static TypeMapper<ITrigger, IStimulus> ConfigureMapping(SimulationLevel simulationLevel)
        {
            var result = new TypeMapper<ITrigger, IStimulus>();

            result.Add(typeof(IMovement), typeof(IVisible));
            result.Add(typeof(IHit), typeof(IPain));

            if (simulationLevel == SimulationLevel.Moderate || simulationLevel == SimulationLevel.Complex)
            {
                result.Add(typeof(IAwaken), typeof(IVisible));
                result.Add(typeof(ISleep), typeof(IVisible));
            }

            if(simulationLevel == SimulationLevel.Complex)
            {
                result.Add(typeof(ICook), typeof(IScent));
                result.Add(typeof(IEat), typeof(ITaste));
            }

            return result;
        }


        static void Main(string[] args)
        {
            BehaviorManager.Initialize(SimulationLevel.Complex, ConfigureMapping);


            AgentAspect enemy = new AgentAspect();
            enemy.Name = "Enemy";
            enemy.Position = new Vector3(0, 0, 0);


            AgentAspect player = new AgentAspect();
            player.Name = "Player";
            player.Senses.Add(new SightSense("Sight"));
            player.Position = new Vector3(50, 50, 50);

            SightSense playerSight = (SightSense)player.Senses.First();
            //playerSight.CanDetect.Add(typeof(IVisible));
            //playerSight.Sensed += c_See;

            

            for(float i = 50; i >= 0; i--) 
            {
                foreach (var s in player.Senses)
                {
                    //Console.WriteLine("distance = " + s.DistanceSquaredTo(enemy) + " (" + Math.Pow(s.MinimumDistance, 2) + ")");
                    //Console.WriteLine("  detected = " + s.IsDetecting);
                    //Console.WriteLine("  sensed = " + s.IsSensing);
                    player.Position = new Vector3(player.Position.X - 1f, player.Position.Y - 1f, player.Position.Z - 1f);
                }
            }
        }

        static void c_See(object sender, EventArgs e)
        {
            Console.WriteLine("Player sees enemy!");
        }
    }
}