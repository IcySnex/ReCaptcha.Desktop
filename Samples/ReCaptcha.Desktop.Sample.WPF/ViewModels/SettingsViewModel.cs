using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WPF.Services;

namespace ReCaptcha.Desktop.Sample.WPF.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    readonly ILogger<SettingsViewModel> logger;

    public SettingsViewModel(
        ILogger<SettingsViewModel> logger)
    {
        this.logger = logger;
    }
}