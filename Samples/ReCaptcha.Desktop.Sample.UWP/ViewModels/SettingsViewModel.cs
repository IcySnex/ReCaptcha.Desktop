using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;
using ReCaptcha.Desktop.Sample.UWP.Models;

namespace ReCaptcha.Desktop.Sample.UWP.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        public readonly Configuration Configuration;

        public SettingsViewModel(
            IOptions<Configuration> configuration)
        {
            Configuration = configuration.Value;
        }
    }
}
