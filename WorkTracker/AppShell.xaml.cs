using WorkTracker.Presentation.Views;

namespace WorkTracker
{
    public partial class AppShell : Shell
    {
        public AppShell(Presentation.Views.MainPage mainPage)
        {
            InitializeComponent();
            var shellContent = new ShellContent
            {
                Title = "Home",
                Content = mainPage,
                Route = "MainPage"
            };
            this.Items.Add(shellContent);
        }
    }
}
