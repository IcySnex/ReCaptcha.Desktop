using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace ReCaptcha.Desktop.Sample.UWP.Views
{
    public sealed partial class HomeView : Page
    {
        HomeViewModel viewModel = App.Provider.GetRequiredService<HomeViewModel>();

        public HomeView() =>
            InitializeComponent();
    }
}
