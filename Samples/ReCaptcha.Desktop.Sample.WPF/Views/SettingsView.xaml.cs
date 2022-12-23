using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.WPF.ViewModels;
using System.Windows.Controls;
using System.Windows.Input;

namespace ReCaptcha.Desktop.Sample.WPF.Views;

public partial class SettingsView : UserControl
{
    public SettingsView()
    {
        InitializeComponent();

        DataContext = App.Provider.GetRequiredService<SettingsViewModel>();
    }


    private void OnHttpPortKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter || e.Key == Key.Back || e.Key == Key.Delete || e.Key == Key.Left || e.Key == Key.Right)
            return;

        e.Handled = (e.Key < Key.D0 || e.Key > Key.D9) && (e.Key < Key.NumPad0 || e.Key > Key.NumPad9);
    }
}