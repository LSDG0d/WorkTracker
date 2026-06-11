using WorkTracker.Presentation.ViewModels;

namespace WorkTracker.Presentation.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
        }
    }
}
