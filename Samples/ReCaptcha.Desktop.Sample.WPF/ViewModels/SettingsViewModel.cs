using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;

namespace ReCaptcha.Desktop.Sample.WPF.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    public Models.Configuration Configuration { get; }


    public SettingsViewModel(
        IOptions<Models.Configuration> configuration)
    {
        Configuration = configuration.Value;
    }
}