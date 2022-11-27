using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ReCaptcha.Desktop.Sample.WPF.Services;

namespace ReCaptcha.Desktop.Sample.WPF.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    readonly ILogger<HomeViewModel> logger;

    public HomeViewModel(
        ILogger<HomeViewModel> logger)
    {
        this.logger = logger;
    }


    [ObservableProperty]
    string welcome = "Welcome!";

    [RelayCommand]
    void Navigate()
    {
        Navigation navigation = App.Provider.GetRequiredService<Navigation>();
        navigation.Navigate<SettingsViewModel>();
    }
}