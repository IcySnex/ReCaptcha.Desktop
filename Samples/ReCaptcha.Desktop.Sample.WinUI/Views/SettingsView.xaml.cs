using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using ReCaptcha.Desktop.Sample.WinUI.ViewModels;

namespace ReCaptcha.Desktop.Sample.WinUI.Views;

public sealed partial class SettingsView : Page
{
    SettingsViewModel viewModel = App.Provider.GetRequiredService<SettingsViewModel>();

    public SettingsView() =>
        InitializeComponent();
}