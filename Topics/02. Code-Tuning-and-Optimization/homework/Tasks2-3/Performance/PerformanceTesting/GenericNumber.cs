namespace PerformanceTesting
{
    public class GenericNumber
    {
        public GenericNumber(int value)
        {
            this.Value = value;
        }

        public GenericNumber(double value)
        {
            this.Value = value;
        }

        public GenericNumber(float value)
        {
            this.Value = value;
        }

        public GenericNumber(long value)
        {
            this.Value = value;
        }

        public GenericNumber(decimal value)
        {
            this.Value = value;
        }

        public dynamic Value { get; set; }
    }
}
