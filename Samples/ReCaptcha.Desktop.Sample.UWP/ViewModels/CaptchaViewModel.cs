﻿#nullable enable

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ReCaptcha.Desktop.Sample.UWP.Models;
using System.Threading.Tasks;
using System.Threading;
using System;
using Windows.UI.Xaml.Controls;

namespace ReCaptcha.Desktop.Sample.UWP.ViewModels;

public partial class CaptchaViewModel : ObservableObject
{
    readonly ILogger logger;
    readonly Models.Configuration configuration;
    //readonly ReCaptchaClient captchaClient;

    public CaptchaViewModel(
        ILogger<CaptchaViewModel> logger,
        IOptions<Models.Configuration> configuration)
    //ReCaptchaClient captchaClient)
    {
        this.logger = logger;
        this.configuration = configuration.Value;
        //this.captchaClient = captchaClient;

        HookHandlers();
    }


    CancellationTokenSource? cancelSource;

    void HookHandlers()
    {
        //captchaClient.VerificationRecieved += async (s, e) =>
        //{
        //    logger.LogInformation("[CaptchaViewModel-VerificationRecieved] Verification was recieved\n\t Token: {token}...\n\tOccurred at: {occurred}", e.Token[..15], e.OccurredAt);

        //    if (configuration.ShowHandlerMessages)
        //        await windowHelper.AlertAsync($"Token: {e.Token[..15]}...\nOccurred at: {e.OccurredAt}", "Verification was recieved");
        //};

        //captchaClient.VerificationCancelled += async (s, e) =>
        //{
        //    logger.LogInformation("[CaptchaViewModel-VerificationCancelled] Verification was cancelled\n\tOccurred at {occurred}", e.OccurredAt);

        //    if (configuration.ShowHandlerMessages)
        //        await windowHelper.AlertAsync($"Occurred at {e.OccurredAt}", "Verification was cancelled");
        //};

        //captchaClient.ReCaptchaResized += async (s, e) =>
        //{
        //    logger.LogInformation("[CaptchaViewModel-ReCaptchaResized] ReCaptcha was resized\n\tWidth: {width}\n\tHeight: {height}\n\tOccurred at: {occurred}", e.Width, e.Height, e.OccurredAt);

        //    if (configuration.ShowHandlerMessages)
        //        await windowHelper.AlertAsync($"Width: {e.Width}\nHeight: {e.Height}\nOccurred at: {e.OccurredAt}", "ReCaptcha resized");
        //};
    }

    void UpdateConfigurations()
    {
        //HttpServerConfig httpConfig = new(
        //            url: configuration.HttpUrl,
        //            port: configuration.HttpPort);
        //ReCaptchaConfig reCaptchaConfig = new(
        //    siteKey: configuration.SiteKey,
        //    language: configuration.Language,
        //    tokenRecievedHtml: configuration.TokenRecievedHtml,
        //    tokenRecievedHookedHtml: configuration.TokenRecievedHookedHtml,
        //    httpConfiguration: httpConfig);

        //WindowConfig windowConfig = new(
        //    title: configuration.Title,
        //    icon: configuration.Icon,
        //    owner: mainView,
        //    startupLocation: configuration.StartupLocation,
        //    left: configuration.Left,
        //    top: configuration.Top,
        //    showAsDialog: configuration.ShowAsDialog);

        //captchaClient.Configuration = reCaptchaConfig;
        //captchaClient.WindowConfiguration = windowConfig;

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
        await Task.Delay(1000);
        return;
        // Remove error message and enable loading
        ErrorMessage = null;
        IsLoading = true;

        // Update configuration so ReCaptcha configs are equal to local settings
        UpdateConfigurations();

        try // Create a new cancel token and await verification
        {
            cancelSource = new(configuration.Timeout);
            //Token = await captchaClient.VerifyAsync(cancelSource.Token);
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