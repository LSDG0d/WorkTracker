using WorkTracker.Infrastructure.Data;

namespace WorkTracker.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            return services;
        }
    }
}
