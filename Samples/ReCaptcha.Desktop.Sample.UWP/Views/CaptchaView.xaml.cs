using Microsoft.Extensions.DependencyInjection;
using ReCaptcha.Desktop.Sample.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

namespace ReCaptcha.Desktop.Sample.UWP.Views;

public sealed partial class CaptchaView : Page
{
    CaptchaViewModel viewModel = App.Provider.GetRequiredService<CaptchaViewModel>();

    public CaptchaView() =>
        InitializeComponent();
}