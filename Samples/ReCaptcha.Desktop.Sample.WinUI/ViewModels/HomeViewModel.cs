using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReCaptcha.Desktop.Sample.WinUI.Services;

namespace ReCaptcha.Desktop.Sample.WinUI.ViewModels;

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