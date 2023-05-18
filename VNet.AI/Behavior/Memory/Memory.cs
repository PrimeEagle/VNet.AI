namespace VNet.AI.Behavior.Memory
{
    public abstract class Memory : IMemory
    {
        public bool Enabled { get; set; }
        public Queue<IMemoryFragment> Sensory { get; set; }
        public Queue<IMemoryFragment> ShortTerm { get; set; }
        public Queue<IMemoryFragment> Working { get; set; }
        public Stack<IMemoryFragment> LongTerm { get; set; }


        public Memory()
        {
            Enabled = true;
            Sensory = new Queue<IMemoryFragment>();
            ShortTerm = new Queue<IMemoryFragment>();
            Working = new Queue<IMemoryFragment> ();
            LongTerm = new Stack<IMemoryFragment>();
        }
    }
}
