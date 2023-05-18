namespace VNet.AI.Behavior
{
    public class PropertyEventArgs : EventArgs
    {
        public object Value { get; init; }

        public PropertyEventArgs(object value)
        {
            this.Value = value;
        }
    }
}
