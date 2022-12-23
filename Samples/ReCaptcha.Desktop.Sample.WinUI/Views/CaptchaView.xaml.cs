using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using ReCaptcha.Desktop.Sample.WinUI.ViewModels;

namespace ReCaptcha.Desktop.Sample.WinUI.Views;

public sealed partial class CaptchaView : Page
{
    CaptchaViewModel viewModel = App.Provider.GetRequiredService<CaptchaViewModel>();

    public CaptchaView() =>
        InitializeComponent();
}