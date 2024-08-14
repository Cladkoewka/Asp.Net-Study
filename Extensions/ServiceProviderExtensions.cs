using MetanitExperiments.Services;

namespace MetanitExperiments.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static void AddRandomNumberService(this IServiceCollection services)
        {
            services.AddTransient<RandomNumberService>();
        }
    }
}
