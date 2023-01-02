using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReCaptcha.Desktop.Sample.UWP.Services;

namespace ReCaptcha.Desktop.Sample.UWP.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    readonly Navigation navigation;

    public HomeViewModel(
        Navigation navigation)
    {
        this.navigation = navigation;
    }


    [RelayCommand]
    void NavigateToCaptcha() =>
        navigation.SetCurrentPage("Views.CaptchaView".AsType());
}