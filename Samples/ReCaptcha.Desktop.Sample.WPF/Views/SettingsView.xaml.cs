using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.WPF.ViewModels;
using System.Windows.Controls;

namespace ReCaptcha.Desktop.Sample.WPF.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();

        DataContext = App.Provider.GetRequiredService<SettingsViewModel>();
    }
}