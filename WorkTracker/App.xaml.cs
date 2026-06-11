using Microsoft.Extensions.DependencyInjection;

namespace WorkTracker
{
    public partial class App : IApplication
    {
        public App(AppShell appShell)
        {
            InitializeComponent();
            MainPage = appShell;
        }
    }
}