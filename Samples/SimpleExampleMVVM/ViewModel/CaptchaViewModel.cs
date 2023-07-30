using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReCaptcha.Desktop.WPF.Client.Interfaces;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleExampleMVVM.ViewModel;

public partial class CaptchaViewModel : ObservableObject
{
    readonly IReCaptchaClient reCaptcha;

    public CaptchaViewModel(
        IReCaptchaClient reCaptcha)
    {
        this.reCaptcha = reCaptcha;
    }


    [RelayCommand]
    void OpenBrowser(
        string url) =>
        Process.Start(new ProcessStartInfo()
        {
            FileName = url,
            UseShellExecute = true,
            CreateNoWindow = true
        });



    // The verification will return an official Google reCAPTCHA token which could be used to verify other Google services
    [ObservableProperty]
    string? token = null;

    // This property enables/disables the checked state on the reCAPTCHA widget
    [ObservableProperty]
    bool isChecked = false;

    // This property enables/Disables the loading indicator on the reCAPTCHA widget
    [ObservableProperty]
    bool isLoading = false;

    // This property allows you to show an error message on the reCAPTCHA widget. null if no error
    [ObservableProperty]
    string? errorMessage = null;


    CancellationTokenSource? cancellationTokenSource = null;

    // This method will request a new verification
    [RelayCommand]
    async Task VerifyAsync()
    {
        // Remove any error message if existing and indicate loading
        ErrorMessage = null;
        IsLoading = true;

        try // Start verification
        {
            // Create a new cancellation source with a timeout of one minute
            cancellationTokenSource = new(TimeSpan.FromMinutes(1));
            Token = await reCaptcha.VerifyAsync(cancellationTokenSource.Token);
        }
        catch (TaskCanceledException) // The Verification was cancelled by the user or it timed out
        {
            // Reset token and uncheck
            Token = null;
            IsChecked = false;
        }
        catch (Exception ex) // Unexpected error was thrown
        {
            // Reset token, Set error message and uncheck
            Token = null;
            IsChecked = false;
            ErrorMessage = ex.Message;
        }
        finally
        {
            // Disable loading and reset cancellation source
            IsLoading = false;
            cancellationTokenSource = null;
        }
    }

    // This method will remove the verification or cancel it if currently verificating
    [RelayCommand]
    void RemoveVerification()
    {
        // Reset token and cancel verification if not already reset
        Token = null;
        cancellationTokenSource?.Cancel();
    }


    // Send a new registration or whatever
    [RelayCommand]
    void SendRegistration()
    {
        if (Token is null)
        {
            MessageBox.Show("Please confirm that you are not a robot!", "Verification failed!", MessageBoxButton.OK, MessageBoxImage.Error);
            return;
        }

        // Verification was successful. Here could be a call to another API which requires an official Google reCAPTCHA token
        MessageBox.Show($"Token: {Token}", "Verification successful!", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}