using WorkTracker.Presentation.ViewModels;

namespace WorkTracker.Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainPage>();
            return services;
        }
    }
}
