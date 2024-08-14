namespace MetanitExperiments.Services
{
    public class LongTimeService : ITimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
