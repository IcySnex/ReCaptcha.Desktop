using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using ReCaptcha.Desktop.Sample.WinUI.ViewModels;

namespace ReCaptcha.Desktop.Sample.WinUI.Views;

public sealed partial class HomeView : Page
{
    HomeViewModel viewModel = App.Provider.GetRequiredService<HomeViewModel>();

    public HomeView() =>
        InitializeComponent();
}