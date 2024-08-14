namespace MetanitExperiments.Services
{
    public class RandomCounter : ICounter
    {
        static Random random = new Random();
        private int _value;

        public RandomCounter()
        {
            _value = random.Next();
        }

        public int Value
        {
            get => _value;
        }
    }
}
