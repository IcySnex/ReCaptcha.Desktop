using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace ReCaptcha.Desktop.Sample.UWP.Views
{
    public sealed partial class SettingsView : Page
    {
        SettingsViewModel viewModel = App.Provider.GetRequiredService<SettingsViewModel>();

        public SettingsView() =>
            InitializeComponent();
    }
}
