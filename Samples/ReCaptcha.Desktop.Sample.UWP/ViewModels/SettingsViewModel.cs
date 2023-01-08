using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;

namespace ReCaptcha.Desktop.Sample.UWP.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    public readonly Models.Configuration Configuration;

    public SettingsViewModel(
        IOptions<Models.Configuration> configuration)
    {
        Configuration = configuration.Value;
    }
}