using CommunityToolkit.Mvvm.ComponentModel;

namespace ReCaptcha.Desktop.Sample.UWP.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        public HomeViewModel()
        {

        }


        [ObservableProperty]
        string message = "Hello World UwU :3";
    }
}
