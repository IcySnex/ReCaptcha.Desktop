using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ReCaptcha.Desktop.Sample.WPF.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    readonly MainViewModel mainViewModel;

    public HomeViewModel(
        MainViewModel mainViewModel)
    {
        this.mainViewModel = mainViewModel;
    }


    [RelayCommand]
    void NavigateToCaptcha() =>
        mainViewModel.Navigate<CaptchaViewModel>();
}