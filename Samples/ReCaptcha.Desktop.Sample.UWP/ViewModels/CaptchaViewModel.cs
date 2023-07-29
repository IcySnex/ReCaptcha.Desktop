#nullable enable

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using System.Threading;
using System;
using Windows.UI.Popups;
using Windows.Foundation;
using Windows.UI.Xaml.Media.Imaging;
using ReCaptcha.Desktop.Sample.UWP.Models;
using ReCaptcha.Desktop.UWP.Client.Interfaces;
using ReCaptcha.Desktop.UWP.Configuration;

namespace ReCaptcha.Desktop.Sample.UWP.ViewModels;

public partial class CaptchaViewModel : ObservableObject
{
    readonly ILogger logger;
    readonly Configuration configuration;
    readonly IReCaptchaClient captchaClient;

    public CaptchaViewModel(
        ILogger<CaptchaViewModel> logger,
        IOptions<Configuration> configuration,
        IReCaptchaClient captchaClient)
    {
        this.logger = logger;
        this.configuration = configuration.Value;
        this.captchaClient = captchaClient;

        HookHandlers();
    }


    CancellationTokenSource? cancelSource;

    IAsyncOperation<IUICommand> AlertAsync(
        string message,
        string title) =>
        new MessageDialog(message, title).ShowAsync();

    void HookHandlers()
    {
        captchaClient.VerificationRecieved += async (s, e) =>
        {
            logger.LogInformation("[CaptchaViewModel-VerificationRecieved] Verification was recieved\n\t Token: {token}...\n\tOccurred at: {occurred}", e.Token.Substring(0, 15), e.OccurredAt);

            if (configuration.ShowHandlerMessages)
                await AlertAsync($"Token: {e.Token.Substring(0, 15)}...\nOccurred at: {e.OccurredAt}", "Verification was recieved");
        };

        captchaClient.VerificationCancelled += async (s, e) =>
        {
            logger.LogInformation("[CaptchaViewModel-VerificationCancelled] Verification was cancelled\n\tOccurred at {occurred}", e.OccurredAt);

            if (configuration.ShowHandlerMessages)
                await AlertAsync($"Occurred at {e.OccurredAt}", "Verification was cancelled");
        };

        captchaClient.ReCaptchaResized += async (s, e) =>
        {
            logger.LogInformation("[CaptchaViewModel-ReCaptchaResized] ReCaptcha was resized\n\tWidth: {width}\n\tHeight: {height}\n\tOccurred at: {occurred}", e.Width, e.Height, e.OccurredAt);

            if (configuration.ShowHandlerMessages)
                await AlertAsync($"Width: {e.Width}\nHeight: {e.Height}\nOccurred at: {e.OccurredAt}", "ReCaptcha resized");
        };
    }

    void UpdateConfigurations()
    {
        ReCaptchaConfig reCaptchaConfig = new(
            siteKey: configuration.SiteKey,
            hostName: configuration.HostName,
            language: configuration.Language,
            tokenRecievedHtml: configuration.TokenRecievedHtml,
            tokenRecievedHookedHtml: configuration.TokenRecievedHookedHtml);

        PopupConfig popupConfig = new(
            title: configuration.Title,
            icon : new BitmapImage(new(configuration.Icon)),
            hasTitleBar: configuration.HasTitleBar,
            isDraggable: configuration.IsDragable,
            isDimmed : configuration.IsDimmed,
            hasRoundedCorners: configuration.HasRoundedCorners,
            startupLocation: configuration.StartupLocation,
            left: configuration.Left,
            top: configuration.Top);

        captchaClient.Configuration = reCaptchaConfig;
        captchaClient.PopupConfiguration = popupConfig;

        logger.LogInformation("[CaptchaViewModel-UpdateConfigurations] Updated client configuration and window configuration");
    }


    [ObservableProperty]
    string token = "Press \"I'm not a robot\"!";

    [ObservableProperty]
    bool isChecked = false;

    [ObservableProperty]
    bool isLoading = false;

    [ObservableProperty]
    string? errorMessage;

    [RelayCommand]
    async Task VerifyAsync()
    {
        // Remove error message and enable loading
        ErrorMessage = null;
        IsLoading = true;

        // Update configuration so ReCaptcha configs are equal to local settings
        UpdateConfigurations();

        try // Create a new cancel token and await verification
        {
            cancelSource = new(configuration.Timeout);
            Token = await captchaClient.VerifyAsync(cancelSource.Token);
        }
        catch (TaskCanceledException) // Task was cancelled by user or timed out: Reset token and uncheck 
        {
            Token = "Press \"I'm not a robot\"!";
            IsChecked = false;
        }
        catch (Exception ex) // Error was thrown: Set error message and uncheck 
        {
            Token = $"Exception was thrown: {ex.Message} - {ex.InnerException?.Message}";
            IsChecked = false;
            ErrorMessage = ex.Message;
        }
        finally // Disable loading and reset cancel token
        {
            IsLoading = false;
            cancelSource = null;
        }
    }

    [RelayCommand]
    void RemoveVerification()
    {
        // Reset token and cancel verification if not already reset
        Token = "Press \"I'm not a robot\"!";
        cancelSource?.Cancel();
    }
}