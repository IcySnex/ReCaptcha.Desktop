using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.WPF.Services;
using System.Windows;

namespace ReCaptcha.Desktop.Sample.WPF.Views;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();
        App.Provider.GetRequiredService<Navigation>();
    }
}