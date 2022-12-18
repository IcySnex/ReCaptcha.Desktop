using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Client.WPF;
using ReCaptcha.Desktop.Configuration;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Threading;

namespace ReCaptcha.Desktop.Sample.WPF.ViewModels;

public partial class CaptchaViewModel : ObservableObject
{
    readonly ILogger<CaptchaViewModel> logger;
    readonly Models.Configuration configuration;
    readonly MainViewModel mainViewModel;
    readonly ReCaptchaClient captchaClient;

    public CaptchaViewModel(
        ILogger<CaptchaViewModel> logger,
        IOptions<Models.Configuration> configuration,
        MainViewModel mainViewModel,
        ReCaptchaClient captchaClient)
    {
        this.logger = logger;
        this.configuration = configuration.Value;
        this.mainViewModel = mainViewModel;
        this.captchaClient = captchaClient;

        HookHandlers();
    }


    CancellationTokenSource? cancelSource;

    void HookHandlers()
    {
        captchaClient.VerificationRecieved += (s, e) =>
        {
            string msg = $"Token: {e.Token[..15]}...\nOccurred at: {e.OccurredAt}";

            MessageBox.Show(msg, "Verification was recieved", MessageBoxButton.OK, MessageBoxImage.Information);
            logger.LogInformation($"[CaptchaViewModel-VerificationRecieved] Verification was recieved\n{msg}");
        };

        captchaClient.VerificationCancelled += (s, e) =>
        {
            string msg = $"Occurred at: {e.OccurredAt}";

            MessageBox.Show(msg, "Verification was cancelled", MessageBoxButton.OK, MessageBoxImage.Information);
            logger.LogInformation($"[CaptchaViewModel-VerificationCancelled] Verification was cancelled\n{msg}");
        };

        captchaClient.ReCaptchaResized += (s, e) =>
        {
            string msg = $"Width: {e.Width}\n\tHeight: {e.Height}\n\tOccurred at: {e.OccurredAt}";

            logger.LogInformation($"[CaptchaViewModel-ReCaptchaResized] ReCaptcha was resized\n{msg}");
        };
    }

    void UpdateConfigurations()
    {
        HttpServerConfig httpConfig = new(
                    url: configuration.HttpUrl,
                    port: configuration.HttpPort);
        ReCaptchaConfig reCaptchaConfig = new(
            siteKey: configuration.SiteKey,
            language: configuration.Language,
            tokenRecievedHtml: configuration.TokenRecievedHtml,
            tokenRecievedHookedHtml: configuration.TokenRecievedHookedHtml,
            httpConfiguration: httpConfig);

        WindowConfig windowConfig = new(
            title: configuration.Title,
            icon: new BitmapImage(new(configuration.Icon)),
            owner: mainViewModel.MainView,
            startupLocation: configuration.StartupLocation,
            left: configuration.Left,
            top: configuration.Top,
            showAsDialog: configuration.ShowAsDialog,
            resizeToCenter: configuration.ResizeToCenter);

        captchaClient.Configuration = reCaptchaConfig;
        captchaClient.WindowConfiguration = windowConfig;

        logger.LogInformation("[CaptchaViewModel-UpdateConfigurations] Updated client configuration and window configuration");
    }


    [ObservableProperty]
    string token = "Press \"I'm not a robot\"!";

    [ObservableProperty]
    bool isChecked = false;

    [ObservableProperty]
    bool isLoading = false;

    [RelayCommand]
    async Task VerifyAsync()
    {
        // IMPLEMENT ERROR LOLLL
        IsErrorVisible = true;
        IsLoading = true;

        UpdateConfigurations();
        try
        {
            cancelSource = new(configuration.Timeout);
            Token = await captchaClient.VerifyAsync(cancelSource.Token);
        }
        catch (Exception ex)
        {
            IsChecked = false;
            IsErrorVisible = true;
            Token = $"Exception was thrown: {ex.Message} - {ex.InnerException?.Message}";
        }
        finally
        {
            cancelSource = null;
        }

        IsLoading = false;
    }

    [RelayCommand]
    void RemoveVerification()
    {
        Token = "Press \"I'm not a robot\"!";
        cancelSource?.Cancel();
    }
}