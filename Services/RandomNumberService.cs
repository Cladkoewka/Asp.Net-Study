namespace MetanitExperiments.Services
{
    public class RandomNumberService
    {
        public int RandomNumber() => new Random().Next();
    }
}
