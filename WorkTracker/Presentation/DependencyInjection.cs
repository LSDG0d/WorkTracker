using WorkTracker.Presentation.ViewModels;
using WorkTracker.Presentation.Views;

namespace WorkTracker.Presentation
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddSingleton<AppShell>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<Presentation.Views.MainPage>();
            return services;
        }
    }
}
