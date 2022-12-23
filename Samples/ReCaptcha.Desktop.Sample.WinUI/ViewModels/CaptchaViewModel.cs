using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ReCaptcha.Desktop.Client.WinUI;
using ReCaptcha.Desktop.Sample.WinUI.Views;

namespace ReCaptcha.Desktop.Sample.WinUI.ViewModels;

public partial class CaptchaViewModel : ObservableObject
{
    readonly ILogger logger;
    readonly Models.Configuration configuration;
    readonly MainView mainView;
    readonly ReCaptchaClient captchaClient;

    public CaptchaViewModel(
        ILogger<CaptchaViewModel> logger,
        IOptions<Models.Configuration> configuration,
        MainView mainView,
        ReCaptchaClient captchaClient)
    {
        this.logger = logger;
        this.configuration = configuration.Value;
        this.mainView = mainView;
        this.captchaClient = captchaClient;
    }
}